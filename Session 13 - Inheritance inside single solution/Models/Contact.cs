using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_13___Inheritance_inside_single_solution.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{Id}{FirstName}{LastName}{Address}{City}{PhoneNumber}";


        }


    }
}
