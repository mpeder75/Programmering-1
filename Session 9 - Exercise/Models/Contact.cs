using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Session_9___Exercise.Models
{
    internal class Contact
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        // tilføjesls af birthday
        public DateTime birthDay { get; set; }
        
        // tilføjelse af fullprop - skriv prop, og find propfull på liste og tab
        // NÅR age kaldes, returnere den CalcAge()
        private int age;

        public int Age
        {
            get 
            {
                age = CalculateAge();
                return age;
            }
         
        }



        int CalculateAge()
        {
            DateTime dd = DateTime.Now;                        

            int calcAge = 0;

            if (birthDay.Year > 1900)
            {
                calcAge = dd.Year - birthDay.Year;

                if (birthDay.Month > dd.Month)
                {
                    calcAge--;
                }
                else if (birthDay.Month == dd.Month)
                {
                    if (birthDay.Day > dd.Day)
                    {
                        calcAge--;
                    }
                }
            }
            return calcAge;
        }       
    }
}
