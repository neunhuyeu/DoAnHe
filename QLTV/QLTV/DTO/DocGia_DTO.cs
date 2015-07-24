using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class DocGia_DTO
    {
        private string _MaDG;

        public string MaDG
        {
            get { return _MaDG; }
            set { _MaDG = value; }
        }
        private string _HoTenDG;

        public string HoTenDG
        {
            get { return _HoTenDG; }
            set { _HoTenDG = value; }
        }
        private string _EmailDG;

        public string EmailDG
        {
            get { return _EmailDG; }
            set { _EmailDG = value; }
        }
        private int _GioiTinhDG;

        public int GioiTinhDG
        {
            get { return _GioiTinhDG; }
            set { _GioiTinhDG = value; }
        }
        private DateTime _NgaySinhDG;

        public DateTime NgaySinhDG
        {
            get { return _NgaySinhDG; }
            set { _NgaySinhDG = value; }
        }
        private string _DiaChiDG;

        public string DiaChiDG
        {
            get { return _DiaChiDG; }
            set { _DiaChiDG = value; }
        }
        private string _DienThoaiDG;

        public string DienThoaiDG
        {
            get { return _DienThoaiDG; }
            set { _DienThoaiDG = value; }
        }
        private DateTime _NgayLamThe;

        public DateTime NgayLamThe
        {
            get { return _NgayLamThe; }
            set { _NgayLamThe = value; }
        }
        private DateTime _NgayHetHan;

        public DateTime NgayHetHan
        {
            get { return _NgayHetHan; }
            set { _NgayHetHan = value; }
        }
        private int _HoatDong;

        public int HoatDong
        {
            get { return _HoatDong; }
            set { _HoatDong = value; }
        }
    }
}
