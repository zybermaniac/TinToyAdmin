using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data.SqlClient;
using System.Data;

namespace TinToy
{
    // Data Access Object - Product module
    public class doClsProduct
    {
        private doCls connect;
        public doClsProduct()
        {
            connect = new doCls();
        }
        public DataTable GetProductByID(int ID)
        {
            string query = "SELECT * FROM Product WHERE ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = ID;
            return connect.ExecuteSelectQuery(query, sqlParameters);
        }
        public int CreateProduct(Product _product)
        {
            string query = "INSERT INTO Product(Name, Description, Image, Price, Availability, CreateDate, LastActiveDate, ActiveFlag) " +
                            " OUTPUT INSERTED.ID " +
                            " VALUES(@name, @description, @image, @price, @availability, GETDATE(), GETDATE(), 1)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("@description", SqlDbType.NVarChar);
            sqlParameters[2] = new SqlParameter("@image", SqlDbType.Image);
            sqlParameters[3] = new SqlParameter("@price", SqlDbType.Decimal);
            sqlParameters[4] = new SqlParameter("@availability", SqlDbType.Int);
            sqlParameters[0].Value = _product.Name;
            sqlParameters[1].Value = _product.Description;
            if (_product.Image == null)
            {
                sqlParameters[2].Value = DBNull.Value;
            }
            else
            {
                sqlParameters[2].Value = _product.Image;
            }
            sqlParameters[3].Value = _product.Price;
            sqlParameters[4].Value = _product.Availability;
            return connect.ExecuteInsertQuery(query, sqlParameters);
        }
        public bool UpdateProduct(Product _product)
        {
            string query = "UPDATE Product SET Name = @name, Description = @description, Image = @image, Price = @price, " +
                           " Availability = @availability, LastActiveDate = GETDATE() WHERE ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("@description", SqlDbType.NVarChar);
            sqlParameters[2] = new SqlParameter("@image", SqlDbType.Image);
            sqlParameters[3] = new SqlParameter("@price", SqlDbType.Decimal);
            sqlParameters[4] = new SqlParameter("@availability", SqlDbType.Int);
            sqlParameters[5] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = _product.Name;
            sqlParameters[1].Value = _product.Description;
            sqlParameters[2].Value = _product.Image;
            sqlParameters[3].Value = _product.Price;
            sqlParameters[4].Value = _product.Availability;
            sqlParameters[5].Value = _product.ID;
            return connect.ExecuteUpdateQuery(query, sqlParameters);
        } 
        public bool DeactivateProduct(int Id)
        {
            string query = "UPDATE Product SET ActiveFlag = 0 " +
                           "WHERE ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = Id;
            return connect.ExecuteUpdateQuery(query, sqlParameters);
        }
        public DataTable SearchProduct(Product prod)
        {
            string clause = "";
            // search by name, description
            clause += "Name LIKE '%" + prod.Name + "%' AND ";
            clause += "Description LIKE '%" + prod.Description + "%' AND ";
            //..
            //..
            clause += "ActiveFlag = 1";

            string query = "SELECT * FROM Product WHERE " + clause;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return connect.ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
