using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class Sach_DTO
    {
        private string _MaSach;

        public string MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }
        private string _TenSach;

        public string TenSach
        {
            get { return _TenSach; }
            set { _TenSach = value; }
        }
        private string _NoiDungTT;

        public string NoiDungTT
        {
            get { return _NoiDungTT; }
            set { _NoiDungTT = value; }
        }
        private int _SoTrang;

        public int SoTrang
        {
            get { return _SoTrang; }
            set { _SoTrang = value; }
        }
        private int _Gia;

        public int Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private DateTime _NgayNhap;

        public DateTime NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }
        private string _MaNXB;

        public string MaNXB
        {
            get { return _MaNXB; }
            set { _MaNXB = value; }
        }
        private string _MaTG;

        public string MaTG
        {
            get { return _MaTG; }
            set { _MaTG = value; }
        }
        private string _MaTL;

        public string MaTL
        {
            get { return _MaTL; }
            set { _MaTL = value; }
        }
        private int _TinhTrang;

        public int TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }

        public NXB_DTO _NXB_DTO { get; set; }
        public TacGia_DTO _TacGia_DTO { get; set; }
        public TheLoai_DTO _TheLoai_DTO { get; set; }
    }
}
