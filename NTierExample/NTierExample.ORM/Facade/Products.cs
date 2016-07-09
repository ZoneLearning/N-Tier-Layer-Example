using NTierExample.ORM.Entity;
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
        public static bool Add(Product entity)
        {
            SqlCommand command = new SqlCommand("AddProduct", Helper.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@n", entity.ProductName);
            command.Parameters.AddWithValue("@p", entity.UnitPrice);
            command.Parameters.AddWithValue("@s", entity.UnitsInStock);

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
