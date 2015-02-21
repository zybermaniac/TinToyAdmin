using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace TinToy
{
    // Data Access Object - generic
    public class doCls
    {
        private SqlDataAdapter myAdapter;
        private SqlConnection conn;

        // This function will loop through exception stracktrace and extract useful error information into a new readable string
        private string GetSQLErrorMsg(SqlException e)
        {
            StringBuilder errorMsg = new StringBuilder();
            for (int i = 0; i < e.Errors.Count; i++)
            {
                errorMsg.Append("Problem #" + i + Environment.NewLine +
                    "Error Number: " + e.Errors[i].Number + Environment.NewLine +
                    "Message: " + e.Errors[i].Message + Environment.NewLine +
                    "LineNumber: " + e.Errors[i].LineNumber + Environment.NewLine +
                    "Source: " + e.Errors[i].Source + Environment.NewLine +
                    "Procedure: " + e.Errors[i].Procedure + Environment.NewLine);
            }
            return errorMsg.ToString();
        }

        // Constructor
        public doCls()
        {
            myAdapter = new SqlDataAdapter();
            conn = new SqlConnection(ConfigurationManager.AppSettings["dbConnectionString"]);
        }                
        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
        public DataTable ExecuteSelectQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                StreamWriter file = new StreamWriter(@"error.txt", false);
                file.WriteLine(GetSQLErrorMsg(e));
                file.Close();
                return null;
            }
            finally
            {
            }
            return dataTable;
        }   
        public int ExecuteInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            int newID;
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.InsertCommand = myCommand;
                newID = (int)myCommand.ExecuteScalar();
            }
            catch (SqlException e)
            {
                StreamWriter file = new StreamWriter(@"error.txt", false);
                file.WriteLine(GetSQLErrorMsg(e));
                file.Close();
                return 0;
            }
            finally
            {
            }
            return newID;
        } 
        public bool ExecuteUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                StreamWriter file = new StreamWriter(@"error.txt", false);
                file.WriteLine(GetSQLErrorMsg(e));
                file.Close();
                return false;
            }
            finally
            {
            }
            return true;
        }       
    }
}
