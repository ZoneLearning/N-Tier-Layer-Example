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
    public class Categories
    {
        public static DataTable getList()
        {
            return Helper.getListAll("ListCategories");
        }
        public static bool Add(Category entity)
        {
            SqlCommand command = new SqlCommand("AddCategory", Helper.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@n", entity.CategoryName);
            command.Parameters.AddWithValue("@d", entity.Description);

            return Helper.MyExecuteNonQuery(command);
        }

        public static bool Delete(Category entity)
        {
            SqlCommand command = new SqlCommand("DeleteCategory", Helper.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", entity.CategoryID);

            return Helper.MyExecuteNonQuery(command);
        }

        public static bool Update(Category entity)
        {
            SqlCommand command = new SqlCommand("UpdateCategory", Helper.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", entity.CategoryID);
            command.Parameters.AddWithValue("@n", entity.CategoryName);
            command.Parameters.AddWithValue("@d", entity.Description);

            return Helper.MyExecuteNonQuery(command);
        }
    }
}

