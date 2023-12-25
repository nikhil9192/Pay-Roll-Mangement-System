using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePaymentSystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Category { get; set; }
    }

}