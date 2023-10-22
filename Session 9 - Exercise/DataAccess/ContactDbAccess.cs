using Session_9___Exercise.Models;


namespace Session_9___Exercise.DataAccess
{
    internal class ContactDbAccess
    {
        // Liste af Contact objekter oprettes
        List<Contact> contacts;

        // Constructor for at initializere Liste
        public ContactDbAccess()
        {
            contacts = new List<Contact>();
            AddContact();       // metode er i constructor, så metoden hardcoder contacts når objekt istancieres
        }

        
        // Create - Opret en contact med automatisk nyt id fra FindNextId()
        public bool CreateContact(Contact contact)
        {
            // Validering
            bool isValid = ValidateModel(contact);
            if(isValid)
            {
                contact.Id = FindNetxtId();
                contacts.Add(contact);
                return true;
            }
            return false;
        }

        // metode der finder næste id, så når der oprettes en contact i CreateContact vil den få næste id
        int FindNetxtId()
        {
            int nextId = 0;

            foreach(var item in contacts)
            {
                if(item.Id > nextId)
                {
                    nextId = item.Id;
                }
            }
            return nextId +1;

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

        // Update - Opdatere et objekt
        public bool UpdateContact(Contact contact) 
        {
            // Validering
            bool isValid = ValidateModel(contact);
            if (isValid)
            {
                foreach (var con in contacts)
                {
                    if (con.Id == contact.Id)
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
            }
            return false;
        }

        // Delete - Delete en contact
        public bool DeleteContact(int id)
        {
            bool isDeleted = false;

            Contact temp = new Contact();
            foreach(var contact in contacts)
            {
                if(contact.Id == id)
                {
                    temp = contact;
                }
            }
            return contacts.Remove(temp);            
        }



        // Validering
        bool ValidateModel(Contact contact)
        {
            // First & Lastname skal være forskelliog for null
            if(contact.FirstName != null && contact.LastName != null)
            {
                // Firstname skal være mellem 1 og 50 chars 
                if(contact.FirstName.Length > 1 && contact.FirstName.Length < 51)
                {

                    if(contact.LastName.Length > 1 && contact.LastName.Length < 51)
                    {
                        return true;
                    }

                }

            }
            return false;
        }


        // tilføje hardcoded contacts - Denne køres af constructor, når objekt istancieres
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
                Id = 5,
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
