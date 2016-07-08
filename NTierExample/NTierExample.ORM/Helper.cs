using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace NTierExample.ORM
{
    //sadece bu projeden ulaşılacağı için public olmasına gerek yok.
    class Helper  // internal
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString);

        public static SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

    }
}
