using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTV.DAL
{
    public class ConnectDB
    {
        //private SqlConnection conn;
        //private SqlDataAdapter da;
        //private DataTable dt;

        #region Varialbles
        private SqlConnection connect;
        #endregion

        #region Mothods
        /// <summary>
        /// Create connection database method
        /// </summary>
        public ConnectDB()
        {
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=hoang;Initial Catalog=QLTV;Integrated Security=True";
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error: " + sqlEx.Message);
            }
            //finally
            //{
            //    connect.Close();
            //}
        }

        /// <summary>
        /// Get data from database non parameter
        /// </summary>
        /// <param name="sql">store procedure name</param>
        /// <returns>table have data</returns>
        public DataTable LoadData(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connect) { CommandType = CommandType.StoredProcedure };
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Function get data form database have some parameter
        /// </summary>
        /// <param name="sql"> store procedure name </param>
        /// <param name="name"> parameters name </param>
        /// <param name="value"> value of parameters </param>
        /// <param name="parameters"> number of parameters </param>
        /// <returns></returns>
        public DataTable LoadData(string sql,
            string[] name,
            object[] value,
            int parameters)
        {
            SqlCommand command = new SqlCommand(sql, connect) { CommandType = CommandType.StoredProcedure };
            for (int i = 0; i < parameters; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Update data into database no parameter
        /// </summary>
        /// <param name="sql"> store procedure name </param>
        /// <returns> Check update ( 1 is success, 0 non-fail) </returns>
        public int Update(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connect) { CommandType = CommandType.StoredProcedure };
            return command.ExecuteNonQuery();
        }

        /// <summary>
        /// Update data into database have some parameter
        /// </summary>
        /// <param name="sql"> store procedure name </param> 
        /// <param name="name"> parameter name </param>
        /// <param name="value">parameter value </param>
        /// <param name="parameters"> number of parameter </param>
        /// <returns> Check update ( 1 is success, 0 non-fail) </returns>
        public int Update(string sql,
            string[] name,
            object[] value,
            int parameters)
        {
            SqlCommand command = new SqlCommand(sql, connect) { CommandType = CommandType.StoredProcedure };

            for (int i = 0; i < parameters; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            return command.ExecuteNonQuery();
        }
        #endregion

        // Tạo constructor goi kết nối khi new lớp ConnectData
        //public ConnectDB()
        //{
        //    Connect();
        //}

        ////Khai bao chuoi ket noi CSDL
        //private string strConnect = @"Data Source=.;Initial Catalog=QLTV;Integrated Security=True";
        ////Kết nối
        //public void Connect()
        //{
        //     try
        //    {
        //        conn = new SqlConnection(strConnect);
        //        conn.Open(); // Mo ket noi
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Không thể kết nối tới Cơ Sở Dữ Liệu !" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        ////Hàm lấy dữ liệu từ Database theo câu lệnh sql truyền vào
        //public  DataTable getdata(string sql)
        //{
        //    // Tạo dataApdapter, thực hiện câu lệnh query
        //    da = new SqlDataAdapter(sql, conn);
        //    // Đổ dữ liệu vào DataTable
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}

        ////Hàm Thêm, Cập nhật, Xóa dữ liệu theo câu lệnh sql đưa vào
        //public bool ThucThiSQL(string sql)
        //{
        //    int numRecordsEffect = 0;
        //    try
        //    {
        //        if (conn.State == ConnectionState.Closed)
        //            conn.Open();
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        numRecordsEffect = cmd.ExecuteNonQuery();
        //        if (conn.State == ConnectionState.Open)
        //            conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("LỖI ĐÂY NÀY : " + ex.Message,"Thông báo lỗi !",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //    }
        //    if (numRecordsEffect > 0)
        //        return true;
        //    return false;
        //}

        ////Hàm kiểm tra sự tồn tại
        public bool KiemTraTonTai(string nameTable, string nameFiled, string value)
        {
            string sql = "SELECT * FROM " + nameTable + " WHERE " + nameFiled + " = '" + value + "'";
            DataTable dtTemp = new DataTable();
            
            dtTemp = LoadData(sql);

            if (dtTemp.Rows.Count > 0)
                return true;
            return false;
        }

        // Lấy mã cuối cùng
        public string GetLastID(string nameTable, string nameFiled)
        {
            //Connect();
            string sql = "SELECT TOP (1) " + nameFiled + " FROM " + nameTable + " ORDER BY " + nameFiled + " DESC";
            DataTable dtTemp = new DataTable();

            dtTemp = LoadData(sql);
            // thực hiện câu truy vấn trên
            return dtTemp.Rows[0][nameFiled].ToString();
        }
    }
}
