//! Anonyme metoder er nemmere at brugeen Delegate

using Session_14___Anonyme_metoder;

List<Contact> myContacts = new List<Contact>();


IEnumerable<Contact> newContacts = myContacts.Where(delegate (Contact con)
{
    return con.Id > 2;
});