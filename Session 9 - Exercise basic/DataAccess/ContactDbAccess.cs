using Session_9___Exercise_basic.Models;

namespace Session_9___Exercise_basic.DataAccess
{
    internal class ContactDbAccess
    {

        List<Contact> contacts;

        public ContactDbAccess()
        {
            contacts = new List<Contact>();
            AddData();
        }


        // Crud Get()

        //todo CRUD - GetAllContacts
        public List<Contact> GetAllContacts()
        {
            return contacts;
        }

        //todo CRUD - GetOneContact
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

        //todo CRUD - Create contact
        public bool CreateContact(Contact contact)
        {
            bool isValid = ValidateModel(contact);

            if (isValid)
            {
                contact.Id = FindNextId();
                contacts.Add(contact);
                return true;
            }
            return false;
        }


        // Find netId Method
        int FindNextId()
        {
            int nextId = 0;
            foreach(var item in contacts)
            {
                if(item.Id > nextId)
                {
                    nextId = item.Id;
                }
            }
            return nextId + 1;
        }

        //todo CRUD - Update a Contact
        public bool UpdateContact(Contact contact)
        {
            if(ValidateModel(contact)) 
            {
                foreach (var con in contacts)
                {
                    if (con.Id == contact.Id)
                    {
                        con.FirstName = contact.FirstName;
                        con.LastName = contact.LastName;
                        return true;
                    }
                }
            }
            return false;
        }

        //todo CRUD - Delete contact
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





        bool ValidateModel(Contact contact)
        {

            if (contact.FirstName != null && contact.LastName != null)
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


        void AddData()
        {
            contacts.Add(new Contact
            {
                Id = 1,
                FirstName = "Homer",
                LastName = "Simpson",
                Address = "741 Terrance Avenue",
                PostalCode = 8771,
                City = "Springfield",
                PhoneNumber = 12345687,
                Email = "duuh@gfmail.com"
            });

            contacts.Add(new Contact
            {
                Id = 2,
                FirstName = "Marge",
                LastName = "Simpson",
                Address = "741 Terrance Avenue",
                PostalCode = 8771,
                City = "Springfield",
                PhoneNumber = 123456778,
                Email = "hotMomma@hotmail.com"
            });

            contacts.Add(new Contact
            {
                Id = 3,
                FirstName = "Maggie",
                LastName = "Simpson",
                Address = "741 Terrance Avenue",
                PostalCode = 8771,
                City = "Springfield",
                PhoneNumber = 123456778,
                Email = "baby@hotmail.com"
            });

            contacts.Add(new Contact
            {
                Id = 4,
                FirstName = "Bart",
                LastName = "Simpson",
                Address = "741 Terrance Avenue",
                PostalCode = 8771,
                City = "Springfield",
                PhoneNumber = 123456778,
                Email = "dude@hotmail.com"
            });

            contacts.Add(new Contact
            {
                Id = 5,
                FirstName = "Lisa",
                LastName = "Simpson",
                Address = "741 Terrance Avenue",
                PostalCode = 8771,
                City = "Springfield",
                PhoneNumber = 123456778,
                Email = "nerd@hotmail.com"
            });
        }
    }
}
