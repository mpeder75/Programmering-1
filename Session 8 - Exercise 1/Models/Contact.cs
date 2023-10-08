
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

        public int Id;
        public string FirstName;
        public string LastName;
        public string Address;
        public int PostalCode;
        public string Town;
        public int Phone;
        public string Email;

        public Contact(int id, string firstName, string lastName, string address, int postalCode, string town, int phone, string email)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PostalCode = postalCode;
            this.Town = town;
            this.Phone = phone;
            this.Email = email;            
        }


        // Opgave 2:
        public int GetId()
        {
            return this.Id;
        }
        public string GetFirstName()
        {
            return this.FirstName;
        }
        public string GetLastName()
        {
            return this.LastName;
        }
        public string GetAddress()
        {
            return this.Address;
        }
        public int GetPostalCode()
        {
            return this.PostalCode;
        }
        public string GetTown()
        {
            return this.Town;
        }
        public int GetPhone()
        {
            return this.Phone;
        }
        public string GetEmail()
        {
            return this.Email;
        }


        public void SetId(int id)
        {
            this.Id = id;
        }
        public void SetFirstName(string firstName)
        {
            this.FirstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            this.LastName = lastName;
        }
        public void SetAdress(string address)
        {
            this.Address = address;
        }
        public void SetPostalCode(int postalCode)
        {
            this.PostalCode = postalCode;
        }
        public void SetTown(string town)
        {
            this.Town = town;
        }
        public void SetPhone(int phone)
        {
            this.Phone = phone;
        }
        public void SetEmail(string email)
        {
            this.Email = email;
        }

    }

}

