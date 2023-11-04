using Session_11___Git_branch.Models;
using Session_11___Git_branch.DataAccess; 



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

// Printe paul objekt while loop
bool exitCondition = false;
while(!exitCondition)
{
Console.WriteLine($"Id: {paul.Id}\nName: {paul.FirstName}\nLast Name: {paul.LastName}" +
$"              \nAddress: {paul.Address}\nCity: {paul.City}\nEmail: {paul.Email}" +
$"              \nPhone: {paul.PhoneNumber}\nPostal code: {paul.PostalCode}");
    exitCondition = true;
}

// Printe paul objekt for-each loop
foreach (var property in paul.GetType().GetProperties())
{
    Console.WriteLine($"{property.Name} : {property.GetValue(paul)} ");
}

// Printe paul objekt for loop
var properties = paul.GetType().GetProperties();

for (int i = 0; i < properties.Length ; i++)
{
    Console.WriteLine($"{properties[i].Name} : {properties[i].GetValue(paul)}");
}



// ContactDbAccess instans oprettes, kaldes db
ContactDbAccess db = new ContactDbAccess();

Contact contactOne = db.GetOneContact(1);

// CRUD: GetAllContacts() testes
List<Contact> getAllContacts = db.GetAllContacts();


//Crud GetOneContact() testes
Contact getOneContact = db.GetOneContact(1);


//CRUD - CreateContact() testes - paul objektet i toppe bruges
bool succes = db.CreateContact(paul);


//CRUD - CreateContact() testes - objektet der laves i metode
bool succesful = db.CreateContact(new Contact
{
    Id = 20,
    FirstName = "paul",
    Address = "sfdg",
    City = "zsdfg",
    Email = "zdfgdsfg",
    LastName = "sdfg",
    PhoneNumber = 12345,
    PostalCode = 234    
});


//CRUD - UpdateContact testes
contactOne.FirstName = "Update from UpdateContact Method";


//CRUD - UpdateContact testes
bool deleteSucces = db.DeleteContact(1);

bool isDeleted = db.DeleteContact(3);

Console.WriteLine(isDeleted);



Contact abe = new Contact { 
    Id = 5, 
    Address = "dsfag", 
    City = "sdfg", 
    Email = "sdfg", 
    FirstName = "xdzf", 
    LastName = "sdrfg", 
    PhoneNumber = 1234, 
    PostalCode = 45, 
    BirthDate = new DateTime(1982, 11, 4) }; 

Console.WriteLine($"abe objerct age is: {abe.Age}");