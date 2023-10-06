
/*
1. Opret en model Contact der indeholder et id, fornavn, efternavn, adresse, postnummer, by, tlf, email. Vælg korrekt datatype....
2. Lav Getter og Setter til alle variabler
3. Modellen placeres i en mappe Models 
*/

namespace Session_8___Exercise_1.Models
{
    public class Contact
    {

        // Opgave 1:

        public int id;
        public string firstName;
        public string lastName;
        public string address;
        public int postalCode;
        public string town;
        public int phone;
        public string email;

        // Opgave 2:
        public int GetId()
        {
            return this.id;
        }
        public string GetFirstName()
        {
            return this.firstName;
        }
        public string GetLastName()
        {
            return this.lastName;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public int GetPostalCode()
        {
            return this.postalCode;
        }
        public string GetTown()
        {
            return this.town;
        }
        public int GetPhone()
        {
            return this.phone;
        }
        public string GetEmail()
        {
            return this.email;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void SetAdress(string address)
        {
            this.address = address;
        }
        public void SetPostalCode(int postalCode)
        {
            this.postalCode = postalCode;
        }
        public void SetTown(string town)
        {
            this.town = town;
        }
        public void GetPhone(int phone)
        {
            this.phone = phone;
        }
        public void GetEmail(string email)
        {
            this.email = email;
        }

    }

}

