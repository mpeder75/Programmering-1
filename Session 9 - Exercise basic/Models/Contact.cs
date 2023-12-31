﻿

namespace Session_9___Exercise_basic.Models
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

        //todo Ekstra - inmplementering af birthday - Udfra birthday, skal alder beregnes
        public DateTime BirthDate { get; set; }
        private int age;

        public int Age
        {
            get 
            {
                age = CalcAge();
                return age; 
            }           
        }



        //todo Ekstra - inmplementering af birthday - Udfra birthday, skal alder beregnes
        int CalcAge()
        {
            DateTime dd = DateTime.Now;

            int calcAge = 0;

            if (BirthDate.Year > 1980)
            {
                calcAge = dd.Year - BirthDate.Year;

                if (BirthDate.Month > dd.Month)
                {
                    calcAge--;
                }
                else if (BirthDate.Day == dd.Day)
                {
                    if (BirthDate.Day > dd.Day)
                    {
                        calcAge--;
                    }
                }
            }
            return calcAge;
        }
    }
}
