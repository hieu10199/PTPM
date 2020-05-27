using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HopDen
{
    public static class DataGV
    {
        static KetNoi kn = new KetNoi();
        static DataGridView _dgv;
        static DataTable dt = new DataTable();
      

        public static DataGridView Dgv
        {
            get { return _dgv; }
            set { _dgv = value; }
        }

        public static  DataTable ketnoidata()
        {
            kn.conn.Open();
            string sqlstring;
            sqlstring = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(sqlstring, kn.conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kn.conn.Close();
            return dt;
        }


        public static List<string> click( DataGridViewCellEventArgs e) 
        {
           
            DataGridView dv = new DataGridView();
            List<string> lst=new List<string>();
            //DataGridViewRow row = new DataGridViewRow();
            //row = dv.Rows[e.RowIndex];
            //MessageBox.Show(row.Cells[0].Value.ToString());
            return lst;
        }
   }
}
