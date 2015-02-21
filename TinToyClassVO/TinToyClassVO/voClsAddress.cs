using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinToy
{
    // Value Object - Address Table
    public class Address
    {
        public int ID {get; set;}
        public string Line1 {get; set;}
        public string Line2 {get; set;} 
        public string City {get; set;}
        public string State {get; set;} 
        public string Zip {get; set;} 
        public int CustomerID {get; set;} 
        public bool PrimaryFlag {get; set;} 
        public System.DateTime CreateDate {get; set;}
        public System.DateTime LastActiveDate {get; set;} 
    }
}
