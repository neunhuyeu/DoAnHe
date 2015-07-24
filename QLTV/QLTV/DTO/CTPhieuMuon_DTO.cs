using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class CTPhieuMuon_DTO
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
        private DateTime _HanTra;

        public DateTime HanTra
        {
            get { return _HanTra; }
            set { _HanTra = value; }
        }
    }
}
