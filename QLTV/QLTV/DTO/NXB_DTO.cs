using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class NXB_DTO
    {
        private string _MaNXB;

        public string MaNXB
        {
            get { return _MaNXB; }
            set { _MaNXB = value; }
        }
        private string _TenNXB;

        public string TenNXB
        {
            get { return _TenNXB; }
            set { _TenNXB = value; }
        }
        private string _DiaChiNXB;

        public string DiaChiNXB
        {
            get { return _DiaChiNXB; }
            set { _DiaChiNXB = value; }
        }
        private string _DienThoaiNXB;

        public string DienThoaiNXB
        {
            get { return _DienThoaiNXB; }
            set { _DienThoaiNXB = value; }
        }
        private string _Website;

        public string Website
        {
            get { return _Website; }
            set { _Website = value; }
        }
    }
}
