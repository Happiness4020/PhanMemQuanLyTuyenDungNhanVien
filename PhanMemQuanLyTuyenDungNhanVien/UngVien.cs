﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyTuyenDungNhanVien
{

    public class UngVien
    {
        string SoCCCD;
        string HoTen;
        DateTime NgaySinh;
        string DiaChi;
        string Email;
        string Sdt;
        string HoVan;
        string ChuyenNganh;
        double Gpa;
        List<string> CacKyNang;
        string ChiTietKyNang;
        string KinhNghiemLamViec;
        string CacDuAn;
        string MucTieuCaNhan;
        string MaVTTD;
        string TenVTTD;



        public UngVien()
        {
        }

        public UngVien(string soCCCD, string hoTen, DateTime ngaySinh, string diaChi, string email, string sdt, string hoVan,
        string chuyenNganh, double gpa, List<string> cacKyNang, string chiTietKyNang, string kinhNghiemLamViec, string cacDuAn,
        string mucTieuCaNhan, string maVTTD, string tenVTTD)
        {
            SoCCCD = soCCCD;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            Email = email;
            Sdt = sdt;
            HoVan = hoVan;
            ChuyenNganh = chuyenNganh;
            Gpa = gpa;
            CacKyNang = cacKyNang;
            ChiTietKyNang = chiTietKyNang;
            KinhNghiemLamViec = kinhNghiemLamViec;
            CacDuAn = cacDuAn;
            MucTieuCaNhan = mucTieuCaNhan;
            MaVTTD = maVTTD;
            TenVTTD = tenVTTD;
        }

        public string soCCCD { get => SoCCCD; set => SoCCCD = value; }
        public string hoTen { get => HoTen; set => HoTen = value; }
        public DateTime ngaySinh { get => NgaySinh; set => NgaySinh = value; }
        public string diaChi { get => DiaChi; set => DiaChi = value; }
        public string email { get => Email; set => Email = value; }
        public string soDienThoai { get => Sdt; set => Sdt = value; }
        public string hocVan { get => HoVan; set => HoVan = value; }
        public string chuyenNganh { get => ChuyenNganh; set => ChuyenNganh = value; }
        public double GPA { get => Gpa; set => Gpa = value; }
        public List<string> cacKyNang { get => CacKyNang; set => CacKyNang = value; }
        public string chiTietKyNang { get => ChiTietKyNang; set => ChiTietKyNang = value; }
        public string kinhNghiemLamViec { get => KinhNghiemLamViec; set => KinhNghiemLamViec = value; }
        public string cacDuAn { get => CacDuAn; set => CacDuAn = value; }
        public string mucTieuCaNhan { get => MucTieuCaNhan; set => MucTieuCaNhan = value; }
        public string maVTTD { get => MaVTTD; set => MaVTTD = value; }
        public string tenVTTD { get => TenVTTD; set => TenVTTD = value; }
    }
}
