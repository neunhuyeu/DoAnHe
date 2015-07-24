using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class TheLoai_DTO
    {
        string _MaTL;

        public string MaTL
        {
            get { return _MaTL; }
            set { _MaTL = value; }
        }
        string _TenTL;

        public string TenTL
        {
            get { return _TenTL; }
            set { _TenTL = value; }
        }
        string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
    }
}
