using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;

namespace TinToy
{
    public class boClsAdminCode
    {
        private doClsAdminCode doAdminCode;
        public boClsAdminCode()
        {
            doAdminCode = new doClsAdminCode();
        }
        public DataTable GetStateList(ref ErrorMessage _errorMessage)
        {
            DataTable dt = doAdminCode.GetStateList();
            if (dt == null)
            {
                _errorMessage.Message += "Data Access Layer: 'GetStateList' fails!";
                _errorMessage.Message += _errorMessage.CheckLogFile;
            }
            return dt;
        }
        public DataTable GetOrderStatusList(ref ErrorMessage _errorMessage)
        {
            DataTable dt = doAdminCode.GetOrderStatusList();
            if (dt == null)
            {
                _errorMessage.Message += "Data Access Layer: 'GetOrderStatusList' fails!";
                _errorMessage.Message += _errorMessage.CheckLogFile;
            }
            return dt;
        }
    }
}
