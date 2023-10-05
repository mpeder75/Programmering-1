using Session_8___Exercise_1.Models;

namespace Session_8___Exercise_1.DataAccess
{
    public class PersonDb
    {
        private List<Contact> myContacts = new List<Contact>(5);


        public List<Contact> ReturnContacts()
        {
            return myContacts;
        }

        public void AddContacts(List<Contact> contactToAdd)
        {
            for(int i = 0; i < contactToAdd.Count; i++)
            {
                myContacts.Add(contactToAdd[i]);
            }
        }

        public Contact ReturnOneContact (int contactIndex)
        {
            if (contactIndex >= 0 && (contactIndex < myContacts.Count))
            {
                return myContacts[contactIndex];
            }
            else
            {
                return null;
            }
        }
    }
}
