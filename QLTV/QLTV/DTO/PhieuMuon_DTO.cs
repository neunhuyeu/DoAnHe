using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class PhieuMuon_DTO
    {
        private string _MaPhieu;

        public string MaPhieu
        {
            get { return _MaPhieu; }
            set { _MaPhieu = value; }
        }
        private string _MaDG;

        public string MaDG
        {
            get { return _MaDG; }
            set { _MaDG = value; }
        }
        private DateTime _NgayMuon;

        public DateTime NgayMuon
        {
            get { return _NgayMuon; }
            set { _NgayMuon = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
    }
}
