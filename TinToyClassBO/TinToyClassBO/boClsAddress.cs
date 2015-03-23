using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;

namespace TinToy
{
    public class boClsAddress
    {
        private doClsAddress doAddress;
        private bool ValidateAddress(Address _address, ref ErrorMessage _errorMessage)
        {
            if (_address.Line1 == "") { _errorMessage.Message += "Line1 "; };
            if (_address.City == "") { _errorMessage.Message += "City "; };
            if (_address.State == "") { _errorMessage.Message += "State "; };
            if (_address.Zip == "") { _errorMessage.Message += "Zip "; };
            if (_errorMessage.Message != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public boClsAddress()
        {
            doAddress = new doClsAddress();
        }
        public int CreateAddress(Address _address, ref ErrorMessage _errorMessage)
        {
            if (ValidateAddress(_address, ref _errorMessage))
            {
                int newAdd = doAddress.CreateAddress(_address);
                if (newAdd == 0)
                {
                    _errorMessage.Message += "Data Access Layer: 'CreateAddress' fails!";
                    _errorMessage.Message += _errorMessage.CheckLogFile;
                    return 0;
                }
                else
                {
                    return newAdd;
                }
            }
            _errorMessage.Message += " BO: Address not validated";
            return 0;
        }
        public bool UpdateAddress(Address _address, ref ErrorMessage _errorMessage)
        {
            if (ValidateAddress(_address, ref _errorMessage))
            {
                bool success = doAddress.UpdateAddress(_address);
                if (!success)
                {
                    _errorMessage.Message += "Data Access Layer: 'UpdateAddress' fails!";
                    _errorMessage.Message += _errorMessage.CheckLogFile;
                    return false;
                }
                else
                {
                    return true;
                }
            }
            _errorMessage.Message += " Business Layer: Address not validated";
            return false;
        }
        public Address GetPrimaryAddressByCustomerID(int customerID, ref ErrorMessage _errorMessage)
        {
            Address _address = new Address();
            DataTable dt = doAddress.GetPrimaryAddressByCustomerID(customerID);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _address.ID = Int32.Parse(dr["ID"].ToString());
                    _address.CustomerID = Int32.Parse(dr["CustomerID"].ToString());
                    _address.Line1 = dr["Line1"].ToString();
                    _address.Line2 = dr["Line2"].ToString();
                    _address.City = dr["City"].ToString();
                    _address.State = dr["State"].ToString();
                    _address.Zip = dr["Zip"].ToString();
                    _address.PrimaryFlag = bool.Parse(dr["PrimaryFlag"].ToString());
                }
            }
            else
            {
                _errorMessage.Message = "Address for Customer " + customerID.ToString() + " does not exist.";
            }
            return _address;
        }
    }
}
