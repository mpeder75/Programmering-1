/*
Opgave Models: 
Opret et objekt Contact der indeholder et id, fornavn, efternavn, adresse, postnummer, by, tlf, email. 
Vælg korrekt datatype. Placeres i en mappe "Models". Brug properties. 

Opret en Mappe "DataAccess" 
Opret en classe ContactDbAccess 
Denne classe skal indeholde en liste af personer (Mindst fem) og metoder til at tilføje - slette 

Test ContactDbAccess fra program.cs dvs. at metoderne afprøves med harcoded værdier. 

Når I modtager værdier fra Program.cs i jeres ContactDbAccess.cs skal i validerer de værdier i modtager. 
Opsæt selv kriterier for fx fornavn skal være på Min2, Maks50 og må ikke være Null 
*/

using Repetition___Session_9___Models.DataAccess;
using Repetition___Session_9___Models.Models;

ContactDbAccess db = new ContactDbAccess();


// opretter et ny Contacts objekt, for at teste om det virker
Contact abe = new Contact
{
    Id = 1,
    FirstName = "Abe",
    LastName = "Simpson",
    Address = "Terrance Avenue",
    City = "Springfield",
    Email = "imOld@gmail.com",
    Phone = 12345678,
    PostalCode = 8888
};

Console.WriteLine($"Abe contact firstname is:  {abe.FirstName}");


// Crud Create - testes
bool isCreated = db.Create(new Contact
{
    Id = 6,
    FirstName = "Alan",
    LastName = "Shearer",
    Address = "Somewhere",
    City = "Newcastle",
    Email = "kingOfGals@gmail.com",
    Phone = 12345677,
    PostalCode = 222
});
Console.WriteLine(isCreated);


// Crud Update - testes
Contact homer = db.GetOneContact(1);
homer.FirstName = "Nyt navn";


// Validator testes
bool isValid = db.ValidateContacts(db.GetOneContact(6));
Console.WriteLine("\nIs Contact 1 validates through ValidateContacts:" + isValid);


// print fra metode PrintAllContacts i ContactDbAccess, der printer alle contacts igennem
Console.Write("\nPrint from PrintAllContact");
db.PrintAllContacts(db.GetAllContacts());

// print fra metode PrintOneContact i ContactDbAccess
Console.Write("\nPrint from PrintOneContact");
db.PrintOneContact(5);
*/