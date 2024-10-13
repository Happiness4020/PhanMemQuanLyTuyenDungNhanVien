using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PhanMemQuanLyTuyenDungNhanVien
{
    public class TaiKhoan
    {
        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("matKhau")]
        public string MatKhau { get; set; }

        [BsonElement("quyenTruyCap")]
        public string QuyenTruyCap { get; set; }

        [BsonElement("ngayTaoTaiKhoan")]
        public string NgayTaoTaiKhoan { get; set; }

        [BsonElement("trangThai")]
        public string TrangThai { get; set; }

        public TaiKhoan(string username, string matkhau, string quyentruycap, string ngaytaotaikhoan, string trangthai)
        {
            Username = username;
            MatKhau = matkhau;
            QuyenTruyCap = quyentruycap;
            NgayTaoTaiKhoan = ngaytaotaikhoan;
            TrangThai = trangthai;
        }
    }

    public class NhanVien
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("hoTen")]
        public string HoTen { get; set; }

        [BsonElement("ngaySinh")]
        public string NgaySinh { get; set; }

        [BsonElement("gioiTinh")]
        public string GioiTinh { get; set; }

        [BsonElement("diaChi")]
        public string DiaChi { get; set; }

        [BsonElement("sdt")]
        public string Sdt { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("viTri")]
        public string ViTri { get; set; }

        [BsonElement("ngayVaoLam")]
        public string NgayVaoLam { get; set; }

        [BsonElement("taiKhoan")]
        public TaiKhoan TaiKhoan { get; set; }

        public NhanVien(string hoten, string ngaysinh, string gioitinh, string diachi, string sdt, string email, string vitri, string ngayvaolam, TaiKhoan taikhoan)
        {
            HoTen = hoten;
            NgaySinh = ngaysinh;
            GioiTinh = gioitinh;
            DiaChi = diachi;
            Sdt = sdt;
            Email = email;
            ViTri = vitri;
            NgayVaoLam = ngayvaolam;
            TaiKhoan = taikhoan;
        }
    }
}
