using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;

namespace TinToy
{
    public class boClsCustomer
    {
        private doClsCustomer doCustomer;
        private bool ValidateCustomer(Customer _customer, ref ErrorMessage _errorMessage)
        {
            if (_customer.FirstName == "") { _errorMessage.Message += "FirstName ";};
            if (_customer.LastName == "") { _errorMessage.Message += "LastName ";};
            if (_customer.Login == "") { _errorMessage.Message += "Login "; };
            if (_customer.Password == "") { _errorMessage.Message += "Passowrd "; };
            if (_customer.Email == "") { _errorMessage.Message += "Email "; };
            if (_customer.Phone == "") { _errorMessage.Message += "Phone "; };
            if (_errorMessage.Message != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public boClsCustomer()
        {
            doCustomer = new doClsCustomer();
        }
        public Customer GetCustomerByID(int ID, ref ErrorMessage _errorMessage)
        {
            Customer _customer = new Customer();
            DataTable dt = doCustomer.GetCustomerByID(ID);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _customer.ID = Int32.Parse(dr["ID"].ToString());
                    _customer.FirstName = dr["FirstName"].ToString();
                    _customer.LastName = dr["LastName"].ToString();
                    _customer.Login = dr["Login"].ToString();
                    _customer.Password = dr["Password"].ToString();
                    _customer.Email = dr["Email"].ToString();
                    _customer.Phone = dr["Phone"].ToString();
                }
            }
            else
            {
                _errorMessage.Message = "Customer " + ID.ToString() + " does not exist.";
            }
            return _customer;
        }
        public int CreateCustomer(Customer _customer, ref ErrorMessage _errorMessage)
        {
            if (ValidateCustomer(_customer, ref _errorMessage))
            {
                int newCus = doCustomer.CreateCustomer(_customer);
                if (newCus == 0)
                {
                    _errorMessage.Message += "Data Access Layer: 'CreateCustomer' fails!";
                    _errorMessage.Message += _errorMessage.CheckLogFile;
                    return 0;
                }
                else
                {
                    return newCus;
                }
            }
            _errorMessage.Message += " Business Layer: Customer not validated";
            return 0;
        }
        public bool UpdateCustomer(Customer _customer, ref ErrorMessage _errorMessage)
        {
            if (ValidateCustomer(_customer, ref _errorMessage))
            {
                bool success = doCustomer.UpdateCustomer(_customer);
                if (!success)
                {
                    _errorMessage.Message += "Data Access Layer: 'UpdateCustomer' fails!";
                    _errorMessage.Message += _errorMessage.CheckLogFile;
                    return false;
                }
                else
                {
                    return true;
                }
            }
            _errorMessage.Message += " Business Layer: Customer not validated";
            return false;
        }
        public bool DeactivateCustomer(int Id, ref ErrorMessage _errorMessage)
        {
            if (Id != 0)
            {
                bool success = doCustomer.DeactivateCustomer(Id);
                if (!success)
                {
                    _errorMessage.Message += "Data Access Layer: 'DeactivateCustomer' fails!";
                    _errorMessage.Message += _errorMessage.CheckLogFile;
                    return false;
                }
                else
                {
                    return true;
                }
            }
            _errorMessage.Message += " Business Layer: Invalid Customer ID";
            return false;
        }      
        public DataTable SearchCustomer(Customer cus, ref ErrorMessage _errorMessage)
        {
            DataTable dt = doCustomer.SearchCustomer(cus);
            if (dt == null)
            {
                _errorMessage.Message += "Data Access Layer: 'SearchCustomer' fails!";
                _errorMessage.Message += _errorMessage.CheckLogFile;
            }
            return dt;
        }
        public Customer GetCustomerByLogin(string login, ref ErrorMessage _errorMessage)
        {
            Customer _customer = new Customer();
            DataTable dt = doCustomer.GetCustomerByLogin(login);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _customer.ID = Int32.Parse(dr["ID"].ToString());
                    _customer.FirstName = dr["FirstName"].ToString();
                    _customer.LastName = dr["LastName"].ToString();
                    _customer.Login = dr["Login"].ToString();
                    _customer.Password = dr["Password"].ToString();
                    _customer.Email = dr["Email"].ToString();
                    _customer.Phone = dr["Phone"].ToString();
                }
            }
            else
            {
                _errorMessage.Message = "Username " + login + " does not exist.";
            }
            return _customer;
        }
    }
}
