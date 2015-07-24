using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class NhanVien_DTO
    {
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private string _HoTenNV;

        public string HoTenNV
        {
            get { return _HoTenNV; }
            set { _HoTenNV = value; }
        }
        private int _GioiTinhNV;

        public int GioiTinhNV
        {
            get { return _GioiTinhNV; }
            set { _GioiTinhNV = value; }
        }
        private DateTime _NgaySinhNV;

        public DateTime NgaySinhNV
        {
            get { return _NgaySinhNV; }
            set { _NgaySinhNV = value; }
        }
        private string _DienThoaiNV;

        public string DienThoaiNV
        {
            get { return _DienThoaiNV; }
            set { _DienThoaiNV = value; }
        }
        private string _DiaChiNV;

        public string DiaChiNV
        {
            get { return _DiaChiNV; }
            set { _DiaChiNV = value; }
        }
        private string _EmailNV;

        public string EmailNV
        {
            get { return _EmailNV; }
            set { _EmailNV = value; }
        }
        private DateTime _NgayVaoLam;

        public DateTime NgayVaoLam
        {
            get { return _NgayVaoLam; }
            set { _NgayVaoLam = value; }
        }
        private string _MatKhau;

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        private int _QuyenHan;

        public int QuyenHan
        {
            get { return _QuyenHan; }
            set { _QuyenHan = value; }
        }
    }
}
