using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace PhanMemQuanLyTuyenDungNhanVien
{

    public partial class frmThongKe : Form
    {
        private IMongoCollection<BsonDocument> vitrituyendung;
        public frmThongKe()
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("QLTuyenDungNhanVien");
            vitrituyendung = database.GetCollection<BsonDocument>("vitrituyendung");

            ThongKeSoLuongVitriTuyenDung();
            ThongKeSoLuongDangTuyen();
            ThongKeSoLuongNgungTuyen();
            ThongKeTongSoLuongCantuyen();
            CountTotalUngVien();
            //Gọi hàm tính tuổi trung bình
            double averageAge = TuoiTrungBinh(vitrituyendung);
            lbl_tuoitbungvien.Text = averageAge.ToString();
            //Gọi hàm tính GPA trung bình
            double averageGPA = GPATrungBinh(vitrituyendung);
            lbl_gpatb.Text = averageGPA.ToString();
            GetMostPopularLoaiVTTD();
            //AddDanhSachUngVienField();
        }

        //private void AddDanhSachUngVienField()
        //{
        //    var cursor = vitrituyendung.Find(new BsonDocument()).ToCursor();
        //    var updateDefinitions = new List<UpdateOneModel<BsonDocument>>();

        //    foreach (var document in cursor.ToEnumerable())
        //    {
        //        // Tạo danh sách ứng viên mẫu
        //        var danhSachUngVien = new BsonArray
        //        {
        //            new BsonDocument
        //            {
        //                { "hoTen", "Nguyen Van A" },
        //                { "ngaySinh", "1990-01-01" },
        //                { "GPA", 8.5 }
        //            },
        //            new BsonDocument
        //            {
        //                { "hoTen", "Tran Thi B" },
        //                { "ngaySinh", "1992-05-12" },
        //                { "GPA", 9.0 }
        //            }
        //        };

        //        // Tạo điều kiện để cập nhật tài liệu
        //        var filter = Builders<BsonDocument>.Filter.Eq("_id", document["_id"]);
        //        var update = Builders<BsonDocument>.Update.Set("danhSachUngVien", danhSachUngVien);

        //        // Thêm vào danh sách các cập nhật
        //        updateDefinitions.Add(new UpdateOneModel<BsonDocument>(filter, update));
        //    }

        //    // Thực hiện các cập nhật
        //    var bulkResult = vitrituyendung.BulkWrite(updateDefinitions);

        //    Console.WriteLine($"Modified count: {bulkResult.ModifiedCount}");
        //}
        private void ThongKeSoLuongVitriTuyenDung()
        {
            long totalVitriCount = vitrituyendung.CountDocuments(new BsonDocument()) - 1;
            lbl_slvitritd.Text = totalVitriCount.ToString();
        }

        private void ThongKeSoLuongDangTuyen()
        {
            var filterDangTuyen = Builders<BsonDocument>.Filter.Eq("trangThaiVTTD", 1);
            long dangTuyenCount = vitrituyendung.CountDocuments(filterDangTuyen) - 1;
            lbl_tongdangtuyen.Text = dangTuyenCount.ToString();
        }

        private void ThongKeSoLuongNgungTuyen()
        {
            var filterNgungTuyen = Builders<BsonDocument>.Filter.Eq("trangThaiVTTD", 0);
            long ngungTuyenCount = vitrituyendung.CountDocuments(filterNgungTuyen);
            lbl_tongtamngungtuyen.Text = ngungTuyenCount.ToString();
        }

        private void ThongKeTongSoLuongCantuyen()
        {
            var allDocuments = vitrituyendung.Find(new BsonDocument()).ToList();
            long totalSoLuongTD = 0;
            foreach (var document in allDocuments)
            {
                if (document.Contains("soLuongTD"))
                {
                    totalSoLuongTD += document["soLuongTD"].AsInt32;
                }
            }
            lbl_soluongcantuyen.Text = totalSoLuongTD.ToString();
        }

        private void CountTotalUngVien()
        {
            var totalUngVien = 0;

            // Truy vấn tất cả tài liệu trong collection
            var allDocuments = vitrituyendung.Find(new BsonDocument()).ToList();

            foreach (var document in allDocuments)
            {
                if (document.Contains("danhSachUngVien"))
                {
                    var danhSachUngVien = document["danhSachUngVien"].AsBsonArray;
                    totalUngVien += danhSachUngVien.Count;
                }
            }

            lbl_tongungvien.Text = (totalUngVien - 2).ToString();

        }
        //Hàm tính tuổi trung bình của tất cả ứng viên
        public static double TuoiTrungBinh(IMongoCollection<BsonDocument> collection)
        {
            var candidateAges = new List<int>();

            // Lặp qua tất cả tài liệu trong bộ sưu tập
            foreach (var document in collection.AsQueryable())
            {
                var danhSachUngVien = document.GetValue("danhSachUngVien").AsBsonArray;

                foreach (var candidateBson in danhSachUngVien)
                {
                    var candidate = candidateBson.AsBsonDocument;
                    var ngaySinh = candidate.GetValue("ngaySinh").AsString; // Trích xuất giá trị ngày tháng kiểu chuỗi
                    if (DateTime.TryParse(ngaySinh, out DateTime ngaySinhDate))
                    {
                        ngaySinhDate = DateTime.SpecifyKind(ngaySinhDate, DateTimeKind.Utc);
                        int age = DateTime.UtcNow.Year - ngaySinhDate.Year;
                        if (DateTime.UtcNow < ngaySinhDate.AddYears(age))
                        {
                            age--;
                        }
                        candidateAges.Add(age);
                    }
                    else
                    {
                        Console.WriteLine($"Không thể chuyển đổi ngày tháng: {ngaySinh}");
                    }
                }
            }

            if (candidateAges.Count > 0)
            {
                double averageAge = candidateAges.Average();
                return Math.Round(averageAge, 1);
            }
            else
            {
                return 0;
            }
        }


        //Hàm tính GPA trung bình của tất cả ứng viên
        public static double GPATrungBinh(IMongoCollection<BsonDocument> collection)
        {
            var pipeline = new List<BsonDocument>
        {
            BsonDocument.Parse("{ $unwind: '$danhSachUngVien' }"),  // Bung các phần tử trong mảng ra thành các document riêng lẻ
            BsonDocument.Parse("{ $group: { _id: null, totalGPA: { $sum: '$danhSachUngVien.GPA' }, count: { $sum: 1 } } }"),  // Tính tổng GPA và đếm số lượng ứng viên
            BsonDocument.Parse("{ $project: { _id: 0, averageGPA: { $divide: ['$totalGPA', '$count'] } } }")  // Tính GPA trung bình
        };

            var result = collection.Aggregate<BsonDocument>(pipeline).FirstOrDefault();

            if (result != null)
            {
                double averageGPA = result["averageGPA"].AsDouble;
                // Làm tròn kết quả tới 2 số thập phân
                return Math.Round(averageGPA, 2);
            }

            return 0;
        }

        //Hàm hiển thị lĩnh vực được ứng viên quan tâm nhất
        public void GetMostPopularLoaiVTTD()
        {
            var pipeline = new BsonDocument[]
            {
                BsonDocument.Parse("{ $unwind: '$danhSachUngVien' }"),
                BsonDocument.Parse("{ $group: { _id: '$loaiVTTD', totalUngVien: { $sum: 1 } } }"),
                 BsonDocument.Parse("{ $sort: { totalUngVien: -1 } }"),
                BsonDocument.Parse("{ $limit: 1 }")
            };

            var result = vitrituyendung.Aggregate<BsonDocument>(pipeline).FirstOrDefault();

            if (result != null)
            {
                var mostPopularLoaiVTTD = result["_id"].AsString;
                var totalUngVien = result["totalUngVien"].AsInt32;
                lbl_linhvuc.Text = mostPopularLoaiVTTD + " : " + totalUngVien.ToString();

            }
            else
            {
                lbl_linhvuc.Text = "Không có dữ liệu";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_soluongcantuyen_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_tongdangtuyen_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_tongungvien_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tuoitbungvien_Click(object sender, EventArgs e)
        {

        }
    }
}
