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
        public decimal TaxRate { get; set; }



        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Contact other = (Contact)obj;

            return Id == other.Id &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   Address == other.Address &&
                   City == other.City &&
                   PhoneNumber == other.PhoneNumber &&
                   TaxRate == other.TaxRate;
        }


    }
}
