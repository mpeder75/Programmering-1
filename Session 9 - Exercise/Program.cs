using Session_9___Exercise.DataAccess;
using Session_9___Exercise.Models;


// initialize ContactDbAccess i variablen myDatabase
ContactDbAccess myDatabase = new ContactDbAccess();

// Få alle contacts fra ContactDbAccess.GetAllContacts og gem i Liste
List<Contact> getAllContacts =  myDatabase.GetAllContacts();

// Print alle contacts ud fra getAllContacts variablen
foreach(var contact in getAllContacts)
{
    Console.WriteLine("Contact ID: " + contact.Id);
    Console.WriteLine("First Name: " + contact.FirstName);
    Console.WriteLine("Last Name: " + contact.LastName);
    Console.WriteLine("Address: " + contact.Address);
    Console.WriteLine("Postnummer: " + contact.PostalCode);
    Console.WriteLine("City: " + contact.City);
    Console.WriteLine("Phone: " + contact.PhoneNumber);
    Console.WriteLine("Email: " + contact.Email + "\n");    
}

// Få EN contact fra ContactDbAccess.GetOneContacts og print
Contact getOneContact = myDatabase.GetOneContact(1);
Console.WriteLine("*********************************************************");
Console.WriteLine("Printing getOneContact:");
Console.WriteLine("Contact ID: " + getOneContact.Id);
Console.WriteLine("First Name: " + getOneContact.FirstName);
Console.WriteLine("Last Name: " + getOneContact.LastName);
Console.WriteLine("Address: " + getOneContact.Address);
Console.WriteLine("Postnummer: " + getOneContact.PostalCode);
Console.WriteLine("City: " + getOneContact.City);
Console.WriteLine("Phone: " + getOneContact.PhoneNumber);
Console.WriteLine("Email: " + getOneContact.Email);
Console.WriteLine("*********************************************************");



// ----- Opret en Contact i List<Contact> contacts i ContactDbAcces

// først skal der oprettes et Contact objekt 
Contact michael = new Contact
{
    Id = 10,
    FirstName = "Michael",
    LastName = "Pedersen",
    Address = "Chr. M. Østergaardsvej 2a",
    PostalCode = 8700,
    City = "Horsen",
    PhoneNumber = 60379107,
    Email = "mipe59956@edu.ucl.dk",
};


// Derefter kaldes CreateContact metoden gennem instancen myDatabase  
bool createSuccess = myDatabase.CreateContact(michael);
Console.WriteLine($"\nIs object created? {createSuccess}\n");


// Update en Contact i List<Contact> contacts i ContactDbAcces
getOneContact.FirstName = "Paul";
bool updateSucces = myDatabase.UpdateContact(michael);
Console.WriteLine("Is contact updated? " + updateSucces + "\n");



// Delete contact
bool deleteSuccess = myDatabase.DeleteContact(1);
Console.WriteLine("Is contact deleted? " + deleteSuccess);


Console.WriteLine();

// --------------------- Tilføjesle med DateTime & birthday --------------------- //


// Contact objekt 'abe' oprettes, og DateTime birthDay property fra Contact benyttes
Contact abe = new Contact { Id = 11, FirstName = "Abe", LastName = "Simpson", birthDay = new DateTime(2000, 10, 19) };


Console.WriteLine($"\n{abe.FirstName} is born {abe.birthDay.ToShortDateString()}. His age today is: {abe.Age}");
