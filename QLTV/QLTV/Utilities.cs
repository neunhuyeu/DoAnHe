using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTV.BLL;
using QLTV.DTO;

namespace QLTV
{
    class Utilities
    {
        //Lấy mã kế tiếp
        public static string NextID(string lastID, string prefixID)
        {
            int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
            int lengthNumerID = lastID.Length - prefixID.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;
        }

        #region Thong tin user
        public static NhanVien_DTO user = new NhanVien_DTO();
        #endregion
    }
}
