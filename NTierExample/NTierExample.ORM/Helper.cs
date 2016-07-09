using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

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

        //bu try-catch-finally blogunu insert,update,delete,select işelmlerinin hepsinde kullanacağım için helper sınıfına metod olarak yazıyorum. Sürekli yazmamak için.
        public static bool MyExecuteNonQuery(SqlCommand command)
        {


            try
            {
                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();
                return command.ExecuteNonQuery() > 0;//etkilenen satır sayısı 0'dan büyük ise true döner
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                if (command.Connection.State != ConnectionState.Closed)
                    command.Connection.Close();
            }
        }

    }
}
