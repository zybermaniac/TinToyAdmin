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
    // Data Access Object - Customer module
    public class doClsCustomer
    {
        private doCls connect;
        public doClsCustomer()
        {
            connect = new doCls();
        }
        public DataTable GetCustomerByID(int ID)
        {
            string query = "SELECT * FROM Customer WHERE ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = ID;
            return connect.ExecuteSelectQuery(query, sqlParameters);
        }
        public int CreateCustomer(Customer _customer)
        {
             string query = "INSERT INTO Customer(FirstName, LastName, Login, Password, Email, Phone, ActiveFlag, CreateDate, LastActiveDate) " +
                            " OUTPUT INSERTED.ID " +
                            " VALUES(@firstname, @lastname, @login, @password, @email, @phone, 1, GETDATE(), GETDATE())";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@firstname", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("@lastname", SqlDbType.NVarChar);
            sqlParameters[2] = new SqlParameter("@login", SqlDbType.NVarChar);
            sqlParameters[3] = new SqlParameter("@password", SqlDbType.NVarChar);
            sqlParameters[4] = new SqlParameter("@email", SqlDbType.NVarChar);
            sqlParameters[5] = new SqlParameter("@phone", SqlDbType.NVarChar);
            sqlParameters[0].Value = _customer.FirstName;
            sqlParameters[1].Value = _customer.LastName;
            sqlParameters[2].Value = _customer.Login;
            sqlParameters[3].Value = _customer.Password;
            sqlParameters[4].Value = _customer.Email;
            sqlParameters[5].Value = _customer.Phone;
            return connect.ExecuteInsertQuery(query, sqlParameters);
        }
        public bool UpdateCustomer(Customer _customer)
        {
            string query = "UPDATE Customer SET FirstName = @firstname, LastName = @lastname, Login = @login, Password = @password, " +
                           " Email = @email, Phone = @phone, LastActiveDate = GETDATE() " +
                           " WHERE ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@firstname", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("@lastname", SqlDbType.NVarChar);
            sqlParameters[2] = new SqlParameter("@login", SqlDbType.NVarChar);
            sqlParameters[3] = new SqlParameter("@password", SqlDbType.NVarChar);
            sqlParameters[4] = new SqlParameter("@email", SqlDbType.NVarChar);
            sqlParameters[5] = new SqlParameter("@phone", SqlDbType.NVarChar);
            sqlParameters[6] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = _customer.FirstName;
            sqlParameters[1].Value = _customer.LastName;
            sqlParameters[2].Value = _customer.Login;
            sqlParameters[3].Value = _customer.Password;
            sqlParameters[4].Value = _customer.Email;
            sqlParameters[5].Value = _customer.Phone;
            sqlParameters[6].Value = _customer.ID;
            return connect.ExecuteUpdateQuery(query, sqlParameters);
        } 
        public bool DeactivateCustomer(int Id)
        {
            string query = "UPDATE Customer SET ActiveFlag = 0 " +
                           "WHERE ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = Id;
            return connect.ExecuteUpdateQuery(query, sqlParameters);
        }
        public DataTable SearchCustomer(Customer cus)
        {
            string clause = "";
            // search by firstname, lasname, login, email, phone
            clause += "FirstName LIKE '%" + cus.FirstName + "%' AND ";
            clause += "LastName LIKE '%" + cus.LastName + "%' AND ";
            clause += "Login LIKE '%" + cus.Login + "%' AND ";
            clause += "Email LIKE '%" + cus.Email + "%' AND ";
            clause += "Phone LIKE '%" + cus.Phone + "%' AND ";
            //..
            //..
            clause += "ActiveFlag = 1";

            string query = "SELECT * FROM Customer WHERE " + clause;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return connect.ExecuteSelectQuery(query, sqlParameters);
        }
        public DataTable GetCustomerByLogin(string login)
        {
            string query = "SELECT * FROM Customer " +
                           "WHERE Login = @login";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@login", SqlDbType.NVarChar);
            sqlParameters[0].Value = login;
            return connect.ExecuteSelectQuery(query, sqlParameters);
        }
    }
} 
