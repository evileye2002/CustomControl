using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace CustomControl
{
    public static class SqlClass
    {
        #region Fix
        //Chuỗi kết nối
        public static string connectionString = @"Data Source=DESKTOP-J6D7SL6\SQLEXPRESS;Initial Catalog=TripleX;Integrated Security=True";
        
        //Connection
        public static SqlConnection Connection = new SqlConnection(connectionString);

        //Kết nối
        public static void Connect()
        {
            if(Connection.State != ConnectionState.Open)
                Connection.Open();
        }

        //Ngắt kết nối
        public static void Disconnect()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }

        //Đổ dữ liệu vào bảng
        public static DataTable FillTable(string sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, Connection);
            sda.Fill(table);
            return (table);
        }

        //Update, Insert
        public static void RunSql(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.ExecuteNonQuery();
            cmd.Dispose();//Giải phóng bộ nhớ
        }

        //Select 1 dữ liệu duy nhất từ Sql
        public static string GetOneValue(string sql)
        {
            string kq = "";
            SqlCommand cmd = new SqlCommand(sql, Connection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
                kq = reader.GetValue(0).ToString();

            reader.Close();
            return kq;
        }

        //Reader
        public static SqlDataReader ReadData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            SqlDataReader rd;

            rd = cmd.ExecuteReader();

            return rd;
        }

        //Dataset
        public static DataSet DataSet(string sql)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand(sql, Connection));
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds;
        }

        //Delete
        public static void RunSqlDel(string sql)
        {
            try
            {
                RunSql(sql);
                SharedClass.Alert("Xóa Thành Công!", Form_Alert.enmType.Success);
            }
            catch (Exception ex)
            {
                CMessageBox.Show("Bản Ghi Này Đang Được Lưu Ở CSDL Khác...\nKhông Thể Xóa!", "Có Gì Đó Không Đúng!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
