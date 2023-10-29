using Session_9___Exercise_basic.Models;

namespace Session_9___Exercise_basic.DataAccess
{
    internal class ContactDbAccess
    {
        // List oprettes
        List<Contact> contacts;

        // constructor, hvor List initializeres
        public ContactDbAccess()
        {
            contacts = new List<Contact>();
            AddData();
        }



        public List<Contact> Get()
        {
            return contacts;
        }




        // Metode der tilføjer 5 contacts
        void AddData()
        {
            contacts.Add(new Contact
            {
                Id = 1,
                FirstName = "Maggie",
                LastName = "Simpson",
                Address = "742 Evergreen Terrace",
                City = "Springfield",
                Email = "baby@hotmail.com",
                PhoneNumber = 111111111,
                PostalCode = 8700
            });

            contacts.Add(new Contact
            {
                Id = 2,
                FirstName = "Homer",
                LastName = "Simpson",
                Address = "742 Evergreen Terrace",
                City = "Springfield",
                Email = "duh@gmail.com",
                PhoneNumber = 123456789,
                PostalCode = 8700
            });

            contacts.Add(new Contact
            {
                Id = 3,
                FirstName = "Marge",
                LastName = "Simpson",
                Address = "742 Evergreen Terrace",
                City = "Springfield",
                Email = "mommy@gmail.com",
                PhoneNumber = 123456789,
                PostalCode = 8700
            });

            contacts.Add(new Contact
            {
                Id = 4,
                FirstName = "Lisa",
                LastName = "Simpson",
                Address = "742 Evergreen Terrace",
                City = "Springfield",
                Email = "clever@gmail.com",
                PhoneNumber = 123456789,
                PostalCode = 8700
            });

            contacts.Add(new Contact
            {
                Id = 5,
                FirstName = "Bart",
                LastName = "Simpson",
                Address = "742 Evergreen Terrace",
                City = "Springfield",
                Email = "skate@gmail.com",
                PhoneNumber = 123456789,
                PostalCode = 8700
            });
        }


    }
}
