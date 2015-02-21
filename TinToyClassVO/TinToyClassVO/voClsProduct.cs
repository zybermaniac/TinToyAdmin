using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinToy
{
    // Value Object - Product Table
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public byte[] Image { get; set; } 
        public decimal Price { get; set; }
        public int Availability { get; set; }
        public System.DateTime CreateDate { get; set; } 
        public System.DateTime LastActiveDate { get; set; }
        public bool ActiveFlag { get; set; }
    }
}
