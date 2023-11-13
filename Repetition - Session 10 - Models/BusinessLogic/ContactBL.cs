using Repetition___Session_10___Models.Models;
using Repetition___Session_10___Models.DataAccess;

// Formålet med BuisinessLogic (ContactBL.cs) er:
// • modtager kald fra Program.cs
// • står for validering
// • når der er valideret kalder den DataAccess ContactDA metoderne  

namespace Repetition___Session_10___Models.BusinessLogic
{
    public class ContactBl
    {
        // 1. Opsætter at der er kontakt til ContactDA
        ContactDA db;

        // 2. db istancieres i constructor
        public ContactBl()
        {
            db = new ContactDA();
        }

        // crud - GetAllContacts() kaldes i ContactDa.cs
        public List<Contact> GetAllContacts()
        {
            return db.GetAllContacts();
        }

        // crud - GetAllContacts() kaldes i ContactDa.cs
        public Contact GetOneContact(int id)
        {
            return db.GetOneContact(id);
        }

        // crud - CreateContact() kaldes i ContactDA når det er valideret
        public bool CreateContact(Contact con)
        {
            if(ValidateData(con))
            {
                return db.CreateContact(con);
            }
            return false;
        }



        bool ValidateData(Contact contact)
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



    }
}
