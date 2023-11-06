using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_13___Inheritance_inside_single_solution.Models
{
    public class Employee : Contact
    {
        public int EmployeeId { get; set; }
        public int SalaryLevel { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nFirstname: {FirstName}\nLastname: {LastName}\nAddress: {Address}\nCity: {City}\nPhinenumber: {PhoneNumber}\nEmployeeId: {EmployeeId}\nSalarylevel: {SalaryLevel}\nTitle: {Title}";
        }
    }
}
