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
    // Data Access Object - Address module
    public class doClsAddress
    {
        private doCls connect;
        public doClsAddress()
        {
            connect = new doCls();
        }
        public int CreateAddress(Address _address)
        {
            string query = "INSERT INTO Address(Line1, Line2, City, State, Zip, CustomerID, PrimaryFlag, CreateDate, LastActiveDate) " +
                           " OUTPUT INSERTED.ID " +
                           " VALUES(@line1, @line2, @city, @state, @zip, @customerID, 1, GETDATE(), GETDATE())";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@line1", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("@line2", SqlDbType.NVarChar);
            sqlParameters[2] = new SqlParameter("@city", SqlDbType.NVarChar);
            sqlParameters[3] = new SqlParameter("@state", SqlDbType.NVarChar);
            sqlParameters[4] = new SqlParameter("@zip", SqlDbType.NVarChar);
            sqlParameters[5] = new SqlParameter("@customerID", SqlDbType.Int);
            sqlParameters[0].Value = _address.Line1;
            sqlParameters[1].Value = _address.Line2;
            sqlParameters[2].Value = _address.City;
            sqlParameters[3].Value = _address.State;
            sqlParameters[4].Value = _address.Zip;
            sqlParameters[5].Value = _address.CustomerID;
            return connect.ExecuteInsertQuery(query, sqlParameters);
        }
        public bool UpdateAddress(Address _address)
        {
            string query = "UPDATE Address SET Line1 = @line1, Line2 = @line2, City = @city, " +
                           " State = @state, Zip = @zip, PrimaryFlag = @primaryFlag, LastActiveDate = GETDATE() " +
                           " WHERE ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@line1", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("@line2", SqlDbType.NVarChar);
            sqlParameters[2] = new SqlParameter("@city", SqlDbType.NVarChar);
            sqlParameters[3] = new SqlParameter("@state", SqlDbType.NVarChar);
            sqlParameters[4] = new SqlParameter("@zip", SqlDbType.NVarChar);
            sqlParameters[5] = new SqlParameter("@primaryFlag", SqlDbType.Int);
            sqlParameters[6] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = _address.Line1;
            sqlParameters[1].Value = _address.Line2;
            sqlParameters[2].Value = _address.City;
            sqlParameters[3].Value = _address.State;
            sqlParameters[4].Value = _address.Zip;
            sqlParameters[5].Value = _address.PrimaryFlag;
            sqlParameters[6].Value = _address.ID;
            return connect.ExecuteUpdateQuery(query, sqlParameters);
        } 
        public DataTable GetPrimaryAddressByCustomerID(int customerID)
        {
            string query = "SELECT * FROM Address WHERE CustomerID = @customerId AND PrimaryFlag = 1";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@customerId", SqlDbType.Int);
            sqlParameters[0].Value = customerID;
            return connect.ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
