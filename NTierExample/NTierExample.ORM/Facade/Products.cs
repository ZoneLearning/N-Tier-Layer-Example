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
            return Helper.getListAll("ListProduct");
        }
        public static bool Add(Product entity)
        {
            SqlCommand command = new SqlCommand("AddProduct", Helper.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@n", entity.ProductName);
            command.Parameters.AddWithValue("@p", entity.UnitPrice);
            command.Parameters.AddWithValue("@s", entity.UnitsInStock);

            return Helper.MyExecuteNonQuery(command);

        }

        public static bool Delete(Product entity)
        {
            SqlCommand command = new SqlCommand("DeleteProduct", Helper.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", entity.ProductID);

            return Helper.MyExecuteNonQuery(command);
        }

        public static bool Update(Product entity)
        {
            SqlCommand command = new SqlCommand("UpdateProduct", Helper.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", entity.ProductID);
            command.Parameters.AddWithValue("@n", entity.ProductName);
            command.Parameters.AddWithValue("@p", entity.UnitPrice);
            command.Parameters.AddWithValue("@s", entity.UnitsInStock);

            return Helper.MyExecuteNonQuery(command);
        }
    }
}
