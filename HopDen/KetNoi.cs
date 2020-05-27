using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopDen
{
    public class KetNoi
    {
        SqlConnection _conn;

        public SqlConnection conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public KetNoi()
        {
            _conn = new SqlConnection("Data Source=DOUBLEH\\SQLEXPRESS; Initial Catalog =QL_SinhVien; User ID=sa; Password=sa2012 ");
            SqlCommand cmm = new SqlCommand();
        }
    }
}
