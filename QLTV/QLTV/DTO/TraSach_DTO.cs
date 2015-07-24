using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class TraSach_DTO
    {
        private string _MaPhieu;

        public string MaPhieu
        {
            get { return _MaPhieu; }
            set { _MaPhieu = value; }
        }
        private string _MaSach;

        public string MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private DateTime _NgayTra;

        public DateTime NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }
        private int _PhatHuHong;

        public int PhatHuHong
        {
            get { return _PhatHuHong; }
            set { _PhatHuHong = value; }
        }
        private int _PhatQuaHan;

        public int PhatQuaHan
        {
            get { return _PhatQuaHan; }
            set { _PhatQuaHan = value; }
        }
    }
}
