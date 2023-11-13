using Repetition___Session_9___Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Repetition___Session_9___Models.DataAccess
{
    public class ContactDbAccess
    {

        List<Contact> contacts;

        public ContactDbAccess()
        {
            contacts = new List<Contact>();
            HardcodedContacts();
        }

        // Crud - Read
        public List<Contact> GetAllContacts()
        {
            return contacts;
        }
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

        // Crud - create contact 
        public bool Create(Contact con)
        {
            bool isValid = ValidateContacts(con);

            if (isValid)
            {
                con.Id = FindNextId();
                contacts.Add(con);
                return true;
            }
            return false;
        }

        // Crud - Update
        public bool UpdateContact(Contact con)
        {
            bool isValid = ValidateContacts(con);

            if (isValid)
            {
                foreach (Contact contact in contacts)
                {
                    if (contact.Id == con.Id)
                    {
                        contact.FirstName = con.FirstName;
                        contact.LastName = con.LastName;
                        contact.Address = con.Address;
                        contact.City = con.City;
                        contact.Email = con.Email;
                        contact.Phone = con.Phone;
                        contact.PostalCode = con.PostalCode;
                        return true;
                    }
                }
            }
            return false;
        }

        // crud - delete
        public bool DeleteContact(int id)
        {
            Contact temp = new Contact();

            foreach (var contact in contacts)
            {
                if (contact.Id == id)
                {
                    temp = contact;
                }
            }
            return contacts.Remove(temp);
        }


        // Validering
        public bool ValidateContacts(Contact contact)
        {

            if (contact.FirstName != null & contact.LastName != null)
            {
                if (contact.FirstName.Length > 1 && contact.FirstName.Length < 51)
                {
                    if (contact.LastName.Length > 1 && contact.LastName.Length < 51)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public int FindNextId()
        {
            int nextId = 0;

            foreach (var contact in contacts)
            {
                if (contact.Id > nextId)
                {
                    nextId = contact.Id;
                }
            }
            return nextId + 1;
        }










        // Hardcoded contacts
        void HardcodedContacts()
        {
            contacts.Add(new Contact { Id = 1, FirstName = "Homer", LastName = "Simpson", Address = "Terrance Avenue", City = "Springfield", Email = "Duh@gmail.com", Phone = 87654321, PostalCode = 8888 });
            contacts.Add(new Contact { Id = 2, FirstName = "Lisa", LastName = "Simpson", Address = "Terrance Avenue", City = "Springfield", Email = "clever@gmail.com", Phone = 87654321, PostalCode = 8888 });
            contacts.Add(new Contact { Id = 3, FirstName = "Marge", LastName = "Simpson", Address = "Terrance Avenue", City = "Springfield", Email = "Mommy@gmail.com", Phone = 87654321, PostalCode = 8888 });
            contacts.Add(new Contact { Id = 4, FirstName = "Bart", LastName = "Simpson", Address = "Terrance Avenue", City = "Springfield", Email = "Surfer@gmail.com", Phone = 87654321, PostalCode = 8888 });
            contacts.Add(new Contact { Id = 5, FirstName = "Maggie", LastName = "Simpson", Address = "Terrance Avenue", City = "Springfield", Email = "Baby@gmail.com", Phone = 87654321, PostalCode = 8888 });
        }

        // PrintAllCOntacts method
        public void PrintAllContacts(List<Contact> con)
        {
            foreach (Contact contact in con)
            {
                Console.WriteLine($"\nId: {contact.Id}\nFirstname: {contact.FirstName}\nLastname:{contact.LastName}\nAddress: {contact.Address}\nCity: {contact.City}\nPostalcode: {contact.PostalCode}\nEmail: {contact.Email}\nPhone: {contact.Phone}");
            }
        }

        // PrintOneCOntact method
        public void PrintOneContact(int id)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.Id == id)
                {
                    Console.WriteLine($"\nId: {contact.Id}\nFirstname: {contact.FirstName}\nLastname:{contact.LastName}\nAddress: {contact.Address}\nCity: {contact.City}\nPostalcode: {contact.PostalCode}\nEmail: {contact.Email}\nPhone: {contact.Phone}");
                }
            }
        }
    }
}

