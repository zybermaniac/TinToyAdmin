using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinToy
{
    // Value Object - Order Table
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string Status { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public System.DateTime ShippingDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastActiveDate { get; set; } 
    }
}
