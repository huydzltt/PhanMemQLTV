using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQLTV
{
    class ConnectionDB
    {
        public string GetConnection()
        {
            string con = "Data Source=NDH09121999;Initial Catalog=MHHDL_KhoaLuanQLTV;Integrated Security=True";
            return con;
        }
    }
}
