using Repetition___Session_10___Models.Models;
using Repetition___Session_10___Models.BusinessLogic;



// 1 .Istancier BuisinessLogic så metoderne derfra kan bruges
ContactBl bl = new ContactBl();

// Et contact objekt oprettes for at teste i progam.cs
Contact alanShearer = new Contact
{
    Id = 1,
    FirstName = "Alan",
    LastName = "Shearer",
    Address = "Somewhere in Newcastle",
    City = "Newcastle",
    Email = "TopMan@gmail.com",
    PostalCode = 1111
};


// Kalde i BL og derefter i DA for at få alle Hardcoded contacts
List<Contact> getAllContacts = bl.GetAllContacts();
foreach (Contact item in getAllContacts)
{
    Console.WriteLine($"Firstname: {item.FirstName}");
}

// 
Contact contactOne = bl.GetOneContact(1);
Console.WriteLine("Print form contactOne: " + contactOne.FirstName);

