using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranThanhHai171201099
{
    class database
    {
        string strcon = @"Data Source=DESKTOP-MFCIF4Q\SQLEXPRESS;Initial Catalog=TestKiemTra;Integrated Security=True";
        public SqlConnection con = null;
        SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter dap;
        public void Connection()
        {
            con = new SqlConnection(strcon);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

        }
        public void Disconnect()
        {
            if (con.State == ConnectionState.Open) //n?u dang m?
            {
                con.Close(); //dóng
                con.Dispose(); //hu?
            }

        }
        public void RunSQL123(string sql)
        {
            Connection();
            cmd.CommandText = sql;
            cmd.Connection = con;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Disconnect();
        }
        public DataTable LoadDuLieu(string sql)
        {
            DataTable dt = new DataTable();
            Connection();
            dap = new SqlDataAdapter(sql, con);
            dap.Fill(dt);
            Disconnect();
            return dt;
        }
    }
}
