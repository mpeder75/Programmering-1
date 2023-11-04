using Session_9___Exercise_basic.Models;
using Session_9___Exercise_basic.DataAccess;

/*

//todo ------------- Testning af Contact.cs -------------- //

// Contact objekt "paul" der oprettes med værdier
Contact paul = new Contact 
{ 
Id = 10, 
FirstName = "Paul",
LastName = "McCartney",
Address = "Somewhere 15",
City = "London", 
Email = "lastBeatle@gmail.com",
PhoneNumber = 123456789, 
PostalCode = 1234 
};

// Printe paul objekt
while(true)
{
Console.WriteLine($"Id: {paul.Id}\nName: {paul.FirstName}\nLast Name: {paul.LastName}" +
$"              \nAddress: {paul.Address}\nCity: {paul.City}\nEmail: {paul.Email}" +
$"              \nPhone: {paul.PhoneNumber}\nPostal code: {paul.PostalCode}");
break;
}

*/
//todo ------------- Testning af ContactDbAccess.cs -------------- //

// ContactDbAccess instans oprettes, kaldes db
ContactDbAccess db = new ContactDbAccess();

// CRUD: db.Get() - get all contact testes
List<Contact> getAllContacts = db.Get();

// CRUD: db.Get() get en contact testes
Contact getOneContact = db.Get(1);

Console.WriteLine();
