﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.Runtime.Internal.Transform;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PhanMemQuanLyTuyenDungNhanVien
{
    public class KetNoi
    {
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<BsonDocument> vitrituyendung;
        private IMongoCollection<BsonDocument> nhanvien;
        private IMongoCollection<BsonDocument> ungVien;


        public KetNoi()
        {
            string connectionString = "mongodb://localhost:27017";
            client = new MongoClient(connectionString);
            database = client.GetDatabase("QLTuyenDungNhanVien");
            vitrituyendung = database.GetCollection<BsonDocument>("vitrituyendung");
            nhanvien = database.GetCollection<BsonDocument>("NhanVien");
            ungVien = database.GetCollection<BsonDocument>("UngVien");
        }

        public int KiemTraKetNoi()
        {
            try
            {
                client.ListDatabases();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public string getNameFromMaVTTD(string maVTTD)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("maVTTD", maVTTD);
            var results = vitrituyendung.Find(filter);
            foreach (var result in results.ToList())
            {
                return result["danhSachUngVien"].ToString();
            }
            return "Không xác định";
        }

        public List<UngVien> FillThongTinUngVienTheoMaTTD(string maVTTD)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("maVTTD", maVTTD);
            var results = vitrituyendung.Find(filter).ToList();
            var danhSachUngVien = new List<UngVien>();

            foreach (var result in results)
            {
                if (result.Contains("danhSachUngVien"))
                {
                    // Kiểm tra danh sách ứng viên có tồn tại và không phải là null
                    if (result["danhSachUngVien"] != BsonNull.Value && result["danhSachUngVien"].IsBsonArray)
                    {
                        foreach (var ungVienBson in result["danhSachUngVien"].AsBsonArray)
                        {
                            var ungVien = ConvertBsonToUngVien(ungVienBson.AsBsonDocument);
                            danhSachUngVien.Add(ungVien);
                        }
                    }
                }
                else
                {
                    // Thông báo nếu không có trường 'danhSachUngVien'
                    Console.WriteLine($"Document with maVTTD {maVTTD} does not contain 'danhSachUngVien'.");
                }
            }
            return danhSachUngVien;
        }


        public List<string> LayDanhSachTenVTTD()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var projection = Builders<BsonDocument>.Projection.Include("tenVTTD").Exclude("_id");

            var result = vitrituyendung.Find(filter).Project(projection).ToList();
            var tenVTTDs = new List<string>();

            foreach (var document in result)
            {
                if (!document.Contains("deleted_at") || string.IsNullOrEmpty(document["deleted_at"].ToString()))
                {
                    tenVTTDs.Add(document["tenVTTD"].AsString);
                }
            }
            return tenVTTDs;
        }

        public List<UngVien> FillThongTinUngVienTheoTenTTD(string tenVTTD)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("tenVTTD", tenVTTD);
            var results = ungVien.Find(filter).ToList();
            var danhSachUngVien = new List<UngVien>();
            foreach (var result in results)
            {
                // Giả định rằng thông tin ứng viên đã được lưu trực tiếp trong collection UngVien
                var ungVien = ConvertBsonToUngVien(result); // Chuyển đổi từng tài liệu BsonDocument thành UngVien
                danhSachUngVien.Add(ungVien);
            }

            return danhSachUngVien;
        }


        public int xoaUngVien(string soCCCD)
        {
            var filter = Builders<BsonDocument>.Filter.ElemMatch("danhSachUngVien", Builders<BsonDocument>.Filter.Eq("soCCCD", soCCCD));

            var update = Builders<BsonDocument>.Update.PullFilter("danhSachUngVien", Builders<BsonDocument>.Filter.Eq("soCCCD", soCCCD));

            var updateResult = vitrituyendung.UpdateMany(filter, update);

            if (updateResult.IsAcknowledged && updateResult.ModifiedCount > 0)
            {
                return 1; // Xóa thành công
            }
            else
            {
                return 0; // Không xóa hoặc có lỗi xảy ra
            }
        }

        public DataTable LoadDataToDataTable()
        {
            var results = vitrituyendung.Find(new BsonDocument()).ToList();
            DataTable dt = CreateDataTable();

            foreach (var result in results)
            {
                if (string.IsNullOrEmpty(result.GetValue("deleted_at", "").ToString()))
                {
                    DataRow row = dt.NewRow();
                    row["maVTTD"] = result.GetValue("maVTTD", "").ToString();
                    row["tenVTTD"] = result.GetValue("tenVTTD", "").ToString();
                    row["loaiVTTD"] = result.GetValue("loaiVTTD", "").ToString();
                    row["ngayBatDauTD"] = result.GetValue("ngayBatDauTD", "");
                    row["ngayKetThucTD"] = result.GetValue("ngayKetThucTD", "");
                    row["soLuongTD"] = result.GetValue("soLuongTD", "").ToString();
                    row["mucLuong"] = result.GetValue("mucLuong", "").ToString();
                    row["diaDiem"] = result.GetValue("diaDiem", "").ToString();
                    row["diaChiCuThe"] = result.GetValue("diaChiCuThe", "").ToString();
                    row["hinhThucLamViec"] = result.GetValue("hinhThucLamViec", "").ToString();
                    row["gioiTinh"] = result.GetValue("gioiTinh", "").ToString();
                    row["kinhNghiemYeuCau"] = result.GetValue("kinhNghiemYeuCau", "").ToString();
                    row["moTaVTTD"] = result.GetValue("moTaVTTD", "").ToString();
                    row["kyNangYeuCau"] = string.Join(", ", result.GetValue("kyNangYeuCau", "").ToString());
                    row["yeuCauChiTiet"] = result.GetValue("yeuCauChiTiet", "").ToString();
                    row["quyenLoi"] = result.GetValue("quyenLoi", "").ToString();
                    row["trangThaiVTTD"] = result.GetValue("trangThaiVTTD", "").ToString();
                    row["created_at"] = result.GetValue("created_at", "").ToString();
                    row["updated_at"] = result.GetValue("updated_at", "").ToString();
                    dt.Rows.Add(row);
                }
            }

            return dt;
        }

        private DataTable CreateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("maVTTD");
            dt.Columns.Add("tenVTTD");
            dt.Columns.Add("loaiVTTD");
            dt.Columns.Add("ngayBatDauTD");
            dt.Columns.Add("ngayKetThucTD");
            dt.Columns.Add("soLuongTD");
            dt.Columns.Add("mucLuong");
            dt.Columns.Add("diaDiem");
            dt.Columns.Add("diaChiCuThe");
            dt.Columns.Add("hinhThucLamViec");
            dt.Columns.Add("gioiTinh");
            dt.Columns.Add("kinhNghiemYeuCau");
            dt.Columns.Add("moTaVTTD");
            dt.Columns.Add("kyNangYeuCau");
            dt.Columns.Add("yeuCauChiTiet");
            dt.Columns.Add("quyenLoi");
            dt.Columns.Add("trangThaiVTTD");
            dt.Columns.Add("created_at");
            dt.Columns.Add("updated_at");
            return dt;
        }

        // Nhân viên
        private DataTable CreateDataTable_NhanVien()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("_id");
            dt.Columns.Add("hoTen");
            dt.Columns.Add("ngaySinh");
            dt.Columns.Add("gioiTinh");
            dt.Columns.Add("diaChi");
            dt.Columns.Add("sdt");
            dt.Columns.Add("email");
            dt.Columns.Add("viTri");
            dt.Columns.Add("ngayVaoLam");
            dt.Columns.Add("username");
            dt.Columns.Add("matKhau");
            dt.Columns.Add("quyenTruyCap");
            dt.Columns.Add("ngayTaoTaiKhoan");
            dt.Columns.Add("trangThai");
            return dt;
        }

        // Load collection Nhân viên
        public DataTable LoadData_NhanVien()
        {
            var results = nhanvien.Find(new BsonDocument()).ToList();
            DataTable dt = CreateDataTable_NhanVien();

            foreach (var result in results)
            {
                
                DataRow row = dt.NewRow();
                row["_id"] = result.GetValue("_id", "").ToString();
                row["hoTen"] = result.GetValue("hoTen", "").ToString();
                row["ngaySinh"] = result.GetValue("ngaySinh", "").ToString();
                row["gioiTinh"] = result.GetValue("gioiTinh", "").ToString();
                row["diaChi"] = result.GetValue("diaChi", "");
                row["sdt"] = result.GetValue("sdt", "");
                row["email"] = result.GetValue("email", "").ToString();
                row["viTri"] = result.GetValue("viTri", "").ToString();
                row["ngayVaoLam"] = result.GetValue("ngayVaoLam", "").ToString();
                    
                // Lấy thông tin từ object "taiKhoan"
                if (result.Contains("taiKhoan"))
                {
                    var taiKhoan = result["taiKhoan"].AsBsonDocument;
                    row["username"] = taiKhoan.GetValue("username", "").ToString();
                    row["matKhau"] = taiKhoan.GetValue("matKhau", "").ToString();
                    row["quyenTruyCap"] = taiKhoan.GetValue("quyenTruyCap", "").ToString();
                    row["ngayTaoTaiKhoan"] = taiKhoan.GetValue("ngayTaoTaiKhoan", "").ToString();
                    row["trangThai"] = taiKhoan.GetValue("trangThai", "").ToString();
                }
                else
                {
                    row["username"] = "";
                    row["matKhau"] = "";
                    row["quyenTruyCap"] = "";
                    row["ngayTaoTaiKhoan"] = "";
                    row["trangThai"] = "";
                }
                dt.Rows.Add(row);
            }

            return dt;
        }

        private UngVien ConvertBsonToUngVien(BsonDocument ungVienBson)
        {
            ungVienBson.TryGetValue("soCCCD", out var soCCCDValue);
            ungVienBson.TryGetValue("hoTen", out var hoTenValue);
            ungVienBson.TryGetValue("ngaySinh", out var ngaySinhValue);
            ungVienBson.TryGetValue("diaChi", out var diaChiValue);
            ungVienBson.TryGetValue("email", out var emailValue);
            ungVienBson.TryGetValue("soDienThoai", out var soDienThoaiValue);
            ungVienBson.TryGetValue("hocVan", out var hocVanValue);
            ungVienBson.TryGetValue("chuyenNganh", out var chuyenNganhValue);
            ungVienBson.TryGetValue("GPA", out var GPAValue);
            ungVienBson.TryGetValue("chiTietKyNang", out var chiTietKyNangValue);
            ungVienBson.TryGetValue("kinhNghiemLamViec", out var kinhNghiemLamViecValue);
            ungVienBson.TryGetValue("cacDuAn", out var cacDuAnValue);
            ungVienBson.TryGetValue("mucTieuCaNhan", out var mucTieuCaNhanValue);

            var cacKyNangArray = ungVienBson.TryGetValue("cacKyNang", out var cacKyNangValue) && cacKyNangValue != null && cacKyNangValue.IsBsonArray
                ? cacKyNangValue.AsBsonArray.Select(x => x.ToString()).ToArray()
                : new string[0];

            // Sửa lỗi ngay tại đây
            var ngaySinh = ngaySinhValue.IsBsonDateTime
                ? ngaySinhValue.ToUniversalTime()
                : DateTime.MinValue;

            return new UngVien
            {
                soCCCD = soCCCDValue?.AsString ?? "Không xác định",
                hoTen = hoTenValue?.AsString ?? "Không xác định",
                ngaySinh = ngaySinh, // Sử dụng giá trị DateTime từ BsonDateTime
                diaChi = diaChiValue?.AsString ?? "Không xác định",
                email = emailValue?.AsString ?? "Không xác định",
                soDienThoai = soDienThoaiValue?.AsString ?? "Không xác định",
                hocVan = hocVanValue?.AsString ?? "Không xác định",
                chuyenNganh = chuyenNganhValue?.AsString ?? "Không xác định",
                GPA = GPAValue?.ToDouble() ?? 0,
                cacKyNang = cacKyNangArray.ToList(),
                chiTietKyNang = chiTietKyNangValue?.AsString ?? "Không xác định",
                kinhNghiemLamViec = kinhNghiemLamViecValue?.AsString ?? "Không xác định",
                cacDuAn = cacDuAnValue?.AsString ?? "Không xác định",
                mucTieuCaNhan = mucTieuCaNhanValue?.AsString ?? "Không xác định"
            };
        }

        public bool XoaViTri(string maVTTD)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("maVTTD", maVTTD);

            // Thực hiện xóa tài liệu
            DeleteResult result = vitrituyendung.DeleteOne(filter);

            // Kiểm tra xem có tài liệu nào bị xóa không
            return result.DeletedCount > 0;
        }


        public bool XoaNhanVien(string maNhanVien)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(maNhanVien));

            DeleteResult result = nhanvien.DeleteOne(filter);

            if (result.DeletedCount > 0)
            {
                return true;
            }
            return false;
        }



        public void CapNhatViTriTuyenDung(string maVTTD, string tenVTTD, string loaiVTTD, string ngayBatDauTD, string ngayKetThucTD, int soLuongTD, string mucLuong, string diaDiem, string diaChiCuThe, string hinhThucLamViec, string gioiTinh, int kinhNghiemYeuCau, string moTaVTTD, List<string> kyNangYeuCau, string yeuCauChiTiet, string quyenLoi, int trangThaiVTTD, string updated_at)
        {

            var filter = Builders<BsonDocument>.Filter.Eq("maVTTD", maVTTD);

            var update = Builders<BsonDocument>.Update
                .Set("tenVTTD", tenVTTD)
                .Set("loaiVTTD", loaiVTTD)
                .Set("ngayBatDauTD", ngayBatDauTD)
                .Set("ngayKetThucTD", ngayKetThucTD)
                .Set("soLuongTD", soLuongTD)
                .Set("mucLuong", mucLuong)
                .Set("diaDiem", diaDiem)
                .Set("diaChiCuThe", diaChiCuThe)
                .Set("hinhThucLamViec", hinhThucLamViec)
                .Set("gioiTinh", gioiTinh)
                .Set("kinhNghiemYeuCau", kinhNghiemYeuCau)
                .Set("moTaVTTD", moTaVTTD)
                .Set("kyNangYeuCau", new BsonArray(kyNangYeuCau))
                .Set("yeuCauChiTiet", yeuCauChiTiet)
                .Set("quyenLoi", quyenLoi)
                .Set("trangThaiVTTD", trangThaiVTTD)
                .Set("updated_at", updated_at);

            UpdateResult result = vitrituyendung.UpdateOne(filter, update);


            if (result.ModifiedCount > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
        public bool ThemViTriTuyenDung(string maVTTD, string tenVTTD, string loaiVTTD, DateTime ngayBatDauTD, DateTime ngayKetThucTD, int soLuongTD, string mucLuong, string diaDiem, string diaChiCuThe, string hinhThucLamViec, string gioiTinh
            , int kinhNghiemYeuCau, string moTaVTTD, List<string> kyNangYeuCau, string yeuCauChiTiet, string quyenLoi, int trangThaiVTTD
            , string created_at, string updated_at, string deleted_at)
        {
            var viTriDocument = new BsonDocument
            {
                { "maVTTD", maVTTD },
                { "tenVTTD", tenVTTD },
                { "loaiVTTD", loaiVTTD },
                { "ngayBatDauTD", ngayBatDauTD },
                { "ngayKetThucTD", ngayKetThucTD },
                { "soLuongTD", soLuongTD },
                { "mucLuong", mucLuong },
                { "diaDiem", diaDiem },
                { "diaChiCuThe", diaChiCuThe },
                { "hinhThucLamViec", hinhThucLamViec },
                { "gioiTinh", gioiTinh },
                { "kinhNghiemYeuCau", kinhNghiemYeuCau },
                { "moTaVTTD", moTaVTTD },
                { "kyNangYeuCau", new BsonArray(kyNangYeuCau) },
                { "yeuCauChiTiet", yeuCauChiTiet },
                { "quyenLoi", quyenLoi },
                { "trangThaiVTTD", trangThaiVTTD },
                { "created_at", created_at },
                { "updated_at", updated_at },
                { "deleted_at", deleted_at },
            };

            try
            {

                vitrituyendung.InsertOne(viTriDocument);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm vị trí tuyển dụng: " + ex.Message);
                return false;
            }

        }




        public bool ThemNhanVien(string hoTen, string ngaySinh, string gioiTinh, string diaChi, string sdt, string email, string viTri, string ngayVaoLam, string username, string matKhau, string quyenTruyCap, string ngayTaoTaiKhoan, string trangThai)
        {
            var nhanVienDocument = new BsonDocument
            {
                { "hoTen", hoTen },
                { "ngaySinh", ngaySinh },
                { "gioiTinh", gioiTinh },
                { "diaChi", diaChi },
                { "sdt", sdt },
                { "email", email },
                { "viTri", viTri },
                { "ngayVaoLam", ngayVaoLam },
                { "taiKhoan", new BsonDocument
                    {
                        { "username", username },
                        { "matKhau", matKhau },
                        { "quyenTruyCap", quyenTruyCap },
                        { "ngayTaoTaiKhoan", ngayTaoTaiKhoan },
                        { "trangThai", trangThai }
                    }
                },
            };

            try
            {
                nhanvien.InsertOne(nhanVienDocument);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
                return false;
            }
        }


        public void CapNhatNhanVien(string id, string hoTen, string ngaySinh, string gioiTinh, string diaChi, string sdt, string email, string viTri, string ngayVaoLam, string username, string matKhau, string quyenTruyCap, string trangThai)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(id));

            var update = Builders<BsonDocument>.Update
                .Set("hoTen", hoTen)
                .Set("ngaySinh", ngaySinh)
                .Set("gioiTinh", gioiTinh)
                .Set("diaChi", diaChi)
                .Set("sdt", sdt)
                .Set("email", email)
                .Set("viTri", viTri)
                .Set("ngayVaoLam", ngayVaoLam)
                .Set("taiKhoan.username", username)
                .Set("taiKhoan.matKhau", matKhau)
                .Set("taiKhoan.quyenTruyCap", quyenTruyCap)
                .Set("taiKhoan.trangThai", trangThai);

            UpdateResult result = nhanvien.UpdateOne(filter, update);

            if (result.ModifiedCount > 0)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại");
            }
        }





        public void ThemUngVien(UngVien ungVienMoi)
        {
            // Tạo document ứng viên mới
            var ungVienDocument = new BsonDocument
            {
                { "soCCCD", ungVienMoi.soCCCD },
                { "hoTen", ungVienMoi.hoTen },
                { "ngaySinh", ungVienMoi.ngaySinh },
                { "diaChi", ungVienMoi.diaChi },
                { "email", ungVienMoi.email },
                { "soDienThoai", ungVienMoi.soDienThoai },
                { "hocVan", ungVienMoi.hocVan },
                { "chuyenNganh", ungVienMoi.chuyenNganh },
                { "GPA", ungVienMoi.GPA },
                { "cacKyNang", new BsonArray(ungVienMoi.cacKyNang) }, // Chuyển list sang BsonArray
                { "chiTietKyNang", ungVienMoi.chiTietKyNang },
                { "kinhNghiemLamViec", ungVienMoi.kinhNghiemLamViec },
                { "cacDuAn", ungVienMoi.cacDuAn },
                { "mucTieuCaNhan", ungVienMoi.mucTieuCaNhan },
                { "tenVTTD", ungVienMoi.tenVTTD } // Lưu tên vị trí tuyển dụng
            };

            // Thêm ứng viên vào collection
            ungVien.InsertOne(ungVienDocument);

            Console.WriteLine("Thêm ứng viên thành công!");
        }


        public void SuaUngVien(UngVien ungVienCapNhat)
        {
            // Tạo filter để tìm ứng viên cần sửa
            var filter = Builders<BsonDocument>.Filter.Eq("soCCCD", ungVienCapNhat.soCCCD); // Hoặc sử dụng một thuộc tính khác để tìm kiếm

            // Tạo document cập nhật
            var update = Builders<BsonDocument>.Update
                .Set("hoTen", ungVienCapNhat.hoTen)
                .Set("ngaySinh", ungVienCapNhat.ngaySinh)
                .Set("diaChi", ungVienCapNhat.diaChi)
                .Set("email", ungVienCapNhat.email)
                .Set("soDienThoai", ungVienCapNhat.soDienThoai)
                .Set("hocVan", ungVienCapNhat.hocVan)
                .Set("chuyenNganh", ungVienCapNhat.chuyenNganh)
                .Set("GPA", ungVienCapNhat.GPA)
                .Set("cacKyNang", new BsonArray(ungVienCapNhat.cacKyNang))
                .Set("chiTietKyNang", ungVienCapNhat.chiTietKyNang)
                .Set("kinhNghiemLamViec", ungVienCapNhat.kinhNghiemLamViec)
                .Set("cacDuAn", ungVienCapNhat.cacDuAn)
                .Set("mucTieuCaNhan", ungVienCapNhat.mucTieuCaNhan)
                .Set("tenVTTD", ungVienCapNhat.tenVTTD);

            // Thực hiện cập nhật
            var result = ungVien.UpdateOne(filter, update);

            if (result.ModifiedCount == 0)
            {
                throw new Exception("Không tìm thấy ứng viên để cập nhật.");
            }
        }

    }
}
