using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierExample.ORM.Facade
{
    //Ürünler ile ilgili insert, update, delete, select işlemlerini (metodlarını) barındıran sınıf
   public class Products
    {
        public static DataTable getList()
        {
            SqlDataAdapter adp = new SqlDataAdapter("ListProduct", Helper.Connection);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);

            return dataTable;
        }
    }
}
