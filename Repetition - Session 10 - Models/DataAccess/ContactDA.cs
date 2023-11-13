using Repetition___Session_10___Models.Models;

namespace Repetition___Session_10___Models.DataAccess
{
    public class ContactDA
    {

        List<Contact> contacts;

        public ContactDA()
        {
            contacts = new List<Contact>();
            HardcodedContacts();
        }



        // Crud - Read - GetAllContacts
        public List<Contact> GetAllContacts()
        {
            return contacts;
        }
        // Crud - Read - GetOneContact
        public Contact GetOneContact(int id)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.Id == id)
                {
                    return contact;
                }
            }
            return new Contact();
        }

        // CRUD - Create
        public bool CreateContact(Contact contact)
        {
            contacts.Add(contact);
            return true;
        }

        // Crud - Delete
        public bool DeleteContact(int id)
        {
            Contact temp = new Contact();
            foreach (Contact contact in contacts)
            {

                if (contact.Id == id)
                {
                    temp = contact;
                }
            }
            return contacts.Remove(temp);
        }

        // Crud - Update
        public bool UpdateContact(Contact updatedContact)
        {
            foreach (Contact existingContact in contacts)
            {
                if (existingContact.Id == updatedContact.Id)
                {
                    existingContact.Id = updatedContact.Id;
                    existingContact.FirstName = updatedContact.FirstName;
                    existingContact.LastName = updatedContact.LastName;
                    existingContact.Address = updatedContact.Address;
                    existingContact.City = updatedContact.City;
                    existingContact.Email = updatedContact.Email;
                    existingContact.PostalCode = updatedContact.PostalCode;
                    return true;
                }
            }
            return false;
        }



        void HardcodedContacts()
        {
            contacts.Add(new Contact { Id = 1, FirstName = "Poul", LastName = "Schlütter", Address = "Somwhere in copenhagen", City = "Copenhagen", Email = "YesSir@hotmail.com", PostalCode = 1054 });
            contacts.Add(new Contact { Id = 2, FirstName = "Anders", LastName = "Krebs", Address = "Somwhere in copenhagen", City = "Copenhagen", Email = "YesSir@hotmail.com", PostalCode = 1054 });
            contacts.Add(new Contact { Id = 3, FirstName = "Hans", LastName = "Jørgensen", Address = "Somwhere in copenhagen", City = "Copenhagen", Email = "YesSir@hotmail.com", PostalCode = 1054 });
            contacts.Add(new Contact { Id = 4, FirstName = "Kim", LastName = "Bertram", Address = "Somwhere in copenhagen", City = "Copenhagen", Email = "YesSir@hotmail.com", PostalCode = 1054 });
            contacts.Add(new Contact { Id = 5, FirstName = "Tobias", LastName = "Tobiasen", Address = "Somwhere in copenhagen", City = "Copenhagen", Email = "YesSir@hotmail.com", PostalCode = 1054 });
        }

    }
}

