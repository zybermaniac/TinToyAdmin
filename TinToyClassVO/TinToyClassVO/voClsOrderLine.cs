using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinToy
{
    // Value Object - OrderLine Table
    public class OrderLine
    {
        public int ID { get; set; }
        public int OrderID { get; set; } 
        public int ProductID { get; set; } 
        public int Quantity { get; set; } 
        public decimal Price { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastActiveDate { get; set; } 

    }
}
