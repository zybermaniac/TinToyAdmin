using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinToy
{
    // Value Object - generic
    public class ErrorMessage
    {
        public string Message { get; set; }
        public string CheckLogFile
        {
            get { return " Please contact system administrator."; }
        }
    }
}
