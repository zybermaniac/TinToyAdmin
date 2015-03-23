﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinToy
{
    // Value Object - Customer Table
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastActiveDate { get; set; }
        public bool ActiveFlag { get; set; }
    }
}
