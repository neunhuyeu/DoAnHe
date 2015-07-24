using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ELPManagementSoftware.DataAccess
{
    public class clsConnection_DataAcc
    {
        protected SqlConnection connect = new SqlConnection();
        string connectString = "Data Source=BINDAGOONER;Initial Catalog=ELP Management;Integrated Security=True";

        public clsConnection_DataAcc()
        {
            connect.ConnectionString = connectString;
            if (connect.State == ConnectionState.Closed) connect.Open();
        }

        public void Close()
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
                connect.Dispose();
            }
        }

        public int ExecuteNonQuery(string procName)
        {
            int _Result;
            SqlCommand Cmd = new SqlCommand(procName, connect);
            Cmd.CommandType = CommandType.StoredProcedure;

            /*phan nay dung de kiem tra neu xay ra loi trong khi thao tac voi csdl 
            thi no se khoi phuc lai du lieu ban dau truoc khi chung ta chua thao tac len csdl */
            using (SqlTransaction _Transaction = connect.BeginTransaction())
            {
                try
                {
                    Cmd.Transaction = _Transaction; // gan lenh vao cmd de thuc hien lenh phuc hoi du lieu khi co loi xay ra
                    _Result = Cmd.ExecuteNonQuery();
                    _Transaction.Commit(); /* du lieu se duoc gan tam vao 1 table ,neu khong co loi thi no se dc gan vao csdl
                                            neu loi thi table nay se huy ->khong anh huong dendu lieu trong csdl */
                }
                catch (SqlException ex)
                {
                    _Transaction.Rollback(); // xay ra loi se khoi phuc lai du lieu ban dau
                    throw;
                }
                Cmd.Dispose();
            }
            return _Result;
        }

        public int ExecuteNonQuery(string procName, string[] name, object[] value, int Nparameter)
        {
            int _Result;
            SqlCommand Cmd = new SqlCommand(procName, connect);
            Cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Nparameter; i++)
            {
                Cmd.Parameters.AddWithValue(name[i], value[i]);
            }

            /*phan nay dung de kiem tra neu xay ra loi trong khi thao tac voi csdl
            thi no se khoi phuc lai du lieu ban dau truoc khi chung ta chua thao tac len csdl */
            using (SqlTransaction _Transaction = connect.BeginTransaction())
            {
                try
                {
                    Cmd.Transaction = _Transaction;
                    _Result = Cmd.ExecuteNonQuery();
                    _Transaction.Commit();
                }
                catch
                {
                    _Transaction.Rollback();
                    return 0;
                }
                Cmd.Dispose();
            }
            return _Result;
        }

        public DataTable ExecuteScalar(String procName)
        {
            SqlCommand Cmd = new SqlCommand(procName, connect);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            DataTable table = new DataTable();
            Da.Fill(table);

            Cmd.Dispose();
            Da.Dispose();
            table.Dispose();
            return table;
        }

        public DataTable ExecuteScalar(string procName, string[] name, object[] value, int Nparameter)
        {
            SqlCommand Cmd = new SqlCommand(procName, connect);
            Cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Nparameter; i++)
            {
                Cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            DataTable table = new DataTable();
            Da.Fill(table);

            Cmd.Dispose();
            Da.Dispose();
            table.Dispose();
            return table;
        }
    }
}

