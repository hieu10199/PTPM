using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopDen
{
    public class TestConnet
    {
        KetNoi kn = new KetNoi();
        public void ktConnet()
        {
            try
            {
                kn.conn.Open();
                MessageBox.Show("Connection Open ! ");
                kn.conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}

