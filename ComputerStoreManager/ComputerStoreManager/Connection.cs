using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ComputerStoreManager
{
    class Connection
    {
        public static SqlConnection connect = new SqlConnection("Data Source=DESKTOP-5GFVEEJ\\SQLEXPRESS;Initial Catalog=TechnologyComputer;User ID=sa;Password=2203");
       
    }
}
