using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HopDen
{
    public partial class SeeView : UserControl
    {
        KetNoi kn = new KetNoi();
        DataSet ds_QLSV = new DataSet();
        DataTable dt = new DataTable();
        public SeeView()
        {
            InitializeComponent();
        }

        private void txtChiNhapSO1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.KeyPress += SeeView_KeyPress;

            
        }
        public void settxtChiNhapSO1(string t)
        {
            txtChiNhapSO1.Text = t;
        }

        void SeeView_KeyPress(object sender, KeyPressEventArgs e)
        {

            MessageBox.Show("X");
        }

        private void txtChiNhapSO1_TextChanged(object sender, EventArgs e)
        {

           
            if (txtChiNhapSO1.TextLength == 0)
            {
                lbCMND.Text = "";
                lbGtinh.Text = "";
                lbMaLop.Text = "";
                lbNgaySInh.Text = "";
                lbTenSV.Text = "";
                
            }
            string mssv = txtChiNhapSO1.Text;

            string sql = @"select * from sinhvien where masv ='" +mssv+ "'";

            SqlCommand cmd = new SqlCommand(sql, kn.conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                lbTenSV.Text = row[1].ToString();
                lbMaLop.Text = row[2].ToString();
                lbNgaySInh.Text = row[3].ToString();
                lbGtinh.Text = row[4].ToString();
                lbCMND.Text = row[5].ToString();                     
            }
            kn.conn.Close();
        }


    }
}
