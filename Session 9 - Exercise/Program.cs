using Session_9___Exercise.DataAccess;
using Session_9___Exercise.Models;


// initialize ContactDbAccess i variablen myDatabase
ContactDbAccess myDatabase = new ContactDbAccess();

// Få alle contacts fra ContactDbAccess.GetAllContacts og gem i Liste
List<Contact> getAllContacts =  myDatabase.GetAllContacts();
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

// Få EN contact fra ContactDbAccess.GetOneContacts og gem i Liste
Contact getOneContact = myDatabase.GetOneContact(1);
Console.WriteLine("Print from getOneContact: " + getOneContact);


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


// Derefter kaldesd CreateContact metoden gennem instancen myDatabase
bool succesful = myDatabase.CreateContact(michael);

// Tjek om den er oprettet
Console.WriteLine("michae objekt er oprettet? " + succesful);

// ----- Update en Contact i List<Contact> contacts i ContactDbAcces
getOneContact.FirstName = "Paul";
bool updateSucces = myDatabase.UpdateContact(michael);



// Delete contact
bool deleteSuccesful = myDatabase.DeleteContact(10);
Console.WriteLine("delete contact succesful? " + deleteSuccesful);
