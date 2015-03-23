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
    // Data Access Object - AdminCode module
    public class doClsAdminCode
    {
        private doCls connect;
        public doClsAdminCode()
        {
            connect = new doCls();
        }
        public DataTable GetStateList()
        {
            string query = "SELECT * FROM AdminCode WHERE Category = 'STATE' ORDER BY Description";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return connect.ExecuteSelectQuery(query, sqlParameters);
        }
        public DataTable GetOrderStatusList()
        {
            string query = "SELECT * FROM AdminCode WHERE Category = 'ORDER_STATUS' ORDER BY Description";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return connect.ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
