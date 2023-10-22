using Session_9___Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Session_9___Exercise.DataAccess
{
    internal class ContactDbAccess
    {

        // Liste af Contact objekter
        List<Contact> contacts;

        
        // Constructor for at initializere Liste - constructor shortcut -> ctor+tab+tab
        public ContactDbAccess()
        {
            contacts = new List<Contact>();
            AddContact();
        }



        // Create - Opret en contact
        public bool CreateContact(Contact contact)
        {
            contacts.Add(contact);
            return true;
        }

        // Update - Opdatere et objekt
        public bool UpdateContact(Contact contact)
        {
            foreach(var con in contacts)
            {
                if(con.Id == contact.Id)
                {
                    con.FirstName = contact.FirstName;
                    con.LastName = contact.LastName;
                    con.Address = contact.Address;
                    con.PostalCode = contact.PostalCode;
                    con.City = contact.City;
                    con.PhoneNumber = contact.PhoneNumber;
                    con.Email = contact.Email;
                    return true;                    
                }
            }
            return false;
         }

        // Read - Returner alle contacts
        public List<Contact> GetAllContacts()
        {
            return contacts;
        }

        // Read - Returner en contacts
        public Contact GetOneContact(int id)
        {
            foreach (var contact in contacts)
            {
                if (contact.Id == id)
                {
                    return contact;
                }
            }
            return new Contact();
        }

        public bool DeleteContact(int id)
        {
            foreach(var contact in contacts)
            {
                if(contact.Id == id)
                {
                    contacts.Remove(contact);
                    return true;
                }
            }
            return false;
        }


        // tilføje hardcoded contacts
        void AddContact()
        {
            contacts.Add(new Contact
            {
                Id = 1,
                FirstName = "Alan",
                LastName = "Shearer",
                Address = "Runnymede Road 5",
                City = "Newcastle on Thyne",
                PostalCode = 8800,
                Email = "allanTheMagnificent@gmail.com",
                PhoneNumber = 12345687
            });

            contacts.Add(new Contact
            {
                Id = 2,
                FirstName = "Margrethe Alexandrine Þórhildur",
                LastName = "Ingrid",
                Address = "Hofstat Hofmarskallatet, ​Postboks 2143",
                City = "Copenhagen K",
                PostalCode = 1256,
                Email = "iamTheQueen@gmail.com",
                PhoneNumber = 666
            });

            contacts.Add(new Contact
            {
                Id = 3,
                FirstName = "Nicklas ",
                LastName = "Bendtner",
                Address = "Havneholmen 33",
                City = "Copenhagen K",
                PostalCode = 1561,
                Email = "lordBendtner@yahoo.com",
                PhoneNumber = 11111111
            });

            contacts.Add(new Contact
            {
                Id = 4,
                FirstName = "Gurli",
                LastName = "Gris",
                Address = "Flæskevænget 57",
                City = "Øffeby",
                PostalCode = 100,
                Email = "pinkpork@gmail.com",
                PhoneNumber = 4444445
            });

            contacts.Add(new Contact
            {
                Id = 1,
                FirstName = "Britney",
                LastName = "Speares",
                Address = "Coke boulevard 13",
                City = "Hollywood",
                PostalCode = 123456,
                Email = "iAmBritneyBitches@yahoo.com",
                PhoneNumber = 70241207
            });
        }
    }
}
