
/*
1. Opret en model Contact der indeholder et id, fornavn, efternavn, adresse, postnummer, by, tlf, email. Vælg korrekt datatype....
2. Lav Getter og Setter til alle variabler
3. Modellen placeres i en mappe Models 
4. Opret en classe PersonDb i en mappe DataAccess. 
   Denne skal indeholde en Collection indeholdende mindst 5 Contacts
5. Lav en metode der returnereralle Contacts, en metode der giver mulighed for at tilføje en Contact 
   til listenog en metode der returnere en Contact. Dette sker i PersonDb.
6. Giv nu mulighed for at oprette en Person med input fra console. 
   Husk at teste input. Dette sker i program.cs
7. Tilføj denne til din Collection og udskriv/kald igen. Dette sker i program.cs
*/

namespace Session_8___Exercise_1.Models
{
    public class Contact
    {

        // Opgave 1:

        int id;
        string firstName;
        string lastName;
        string address;
        int postalCode;
        string town;
        int phone;
        string email;

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

