using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopDen
{
    public class btnThem:Button
    {
        KetNoi kn = new KetNoi();
        public btnThem()
        {
            try
            {
                kn.conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công");
                throw;
            }
 
        }
    }
}
