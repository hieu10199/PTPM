using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HopDen;
using System.Data.SqlClient;

namespace DinhHoangHieu_2001170054_BTVNTuan3
{
    public partial class Form1 : Form
    {
        KetNoi kn = new KetNoi();        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TestConnet tcn = new TestConnet();
            tcn.ktConnet();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ketnoidata();
        }

         private void ketnoidata()
        {
               
            DataGV.Dgv = dataGridView1;
            dataGridView1.DataSource = DataGV.ketnoidata();

            DataGV.Dgv = dataGridView1;
                    
        }
         private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             //int numrow;
             //numrow = e.RowIndex;
             //settxtChiNhapSO1(dataGridView1.Rows[numrow].Cells[1].Value.ToString()); ;
             //SeeView.
         }

    }
}
