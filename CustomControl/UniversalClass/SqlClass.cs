using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomControl
{
    public class SqlClass
    {
        #region Fix
        //Đổ dữ liệu vào bảng
        public static DataTable FillTable(string sql, SqlConnection sqlConnection)
        {
            DataTable table = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlConnection);
            sda.Fill(table);
            return (table);
        }

        //Update, Insert
        public static void RunSql(string sql, SqlConnection sqlConnection)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.ExecuteNonQuery();
            cmd.Dispose();//Giải phóng bộ nhớ
        }

        //Select 1 dữ liệu duy nhất từ Sql
        public static string GetOneValue(string sql, SqlConnection sqlConnection)
        {
            string kq = "";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
                kq = reader.GetValue(0).ToString();

            reader.Close();
            return kq;
        }

        //Reader
        public static SqlDataReader ReadData(string sql, SqlConnection sqlConnection)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader rd;

            rd = cmd.ExecuteReader();

            return rd;
        }

        //Dataset
        public static DataSet DataSet(string sql, SqlConnection sqlConnection)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand(sql, sqlConnection));
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds;
        }

        //Delete
        public static void RunSqlDel(string sql, SqlConnection sqlConnection)
        {
            try
            {
                RunSql(sql, sqlConnection);
                CMessageBox.Show("Xóa Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                CMessageBox.Show("Bản Ghi Này Đang Được Lưu Ở CSDL Khác...\nKhông Thể Xóa!", "Có Gì Đó Không Đúng!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
