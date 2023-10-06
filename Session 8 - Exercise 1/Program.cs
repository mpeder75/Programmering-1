/*
1. Opret en model Contact der indeholder et id, fornavn, efternavn, adresse, postnummer, by, tlf, email. Vælg korrekt datatype....
2. Lav Getter og Setter til alle variabler
3. Modellen placeres i en mappe Models 
4. Opret en classe PersonDb i en mappe DataAccess. 
   Denne skal indeholde en Collection indeholdende mindst 5 Contacts
5. Lav en metode der returnereralle Contacts, en metode der giver mulighed for at tilføje en Contact 
   til listenog en metode der returnere en Contact. Dette sker i PersonDb.
6. Giv nu mulighed for at oprette en Person med input fra console. 
   Husk at teste input. Dette sker i program.cs
7. Tilføj denne til din Collection og udskriv/kald igen. Dette sker i program.cs
*/

using Session_8___Exercise_1.Models;
using Session_8___Exercise_1.DataAccess;

string userFirstName;
string userLastName;
string userAddress;
int userPostalCode;
string userTown;
int userPhoneNumber;
string userEmail;
bool exitCondition = false;

PersonDb personDb = new PersonDb();


while (!(exitCondition))
{
    Console.WriteLine("[C]reate Contact");
    Console.WriteLine("[P]rint Contacts");
    Console.WriteLine("[E]xit");
    string userInput = Console.ReadLine();

    if (userInput.Equals("C") || userInput.Equals("c"))
    {
        Random rnd = new Random();
        int num = rnd.Next();
        
        Console.WriteLine("Enter first name:");
        userFirstName = Console.ReadLine();
       

        Console.WriteLine("Enter last name:");
        userLastName = Console.ReadLine();

        Console.WriteLine("Enter address");
        userAddress = Console.ReadLine();

        Console.WriteLine("Enter postalcode");
        userPostalCode = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter town");
        userTown = Console.ReadLine();

        Console.WriteLine("Enter phonenumber:");
        userPhoneNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter email");
        userEmail = Console.ReadLine();

        Contact newContact = new Contact
        {
            id = num,
            firstName = userFirstName,
            lastName = userLastName,
            address = userAddress,
            postalCode = userPostalCode,
            town = userTown,
            phone = userPhoneNumber,
            email = userEmail
        };

        personDb.AddContacts(new List<Contact> { newContact });
        Console.WriteLine("Contact createdn\n");
    } 
    
    if(userInput.Equals("P") || userInput.Equals("p"))
    {
        List<Contact> contacts = personDb.ReturnContacts();

        for (int i = 0; i < contacts.Count; i++)
        {
            Contact contact = contacts[i];

            Console.WriteLine($"ID: {contact.id}");
            Console.WriteLine($"First Name: {contact.firstName}");
            Console.WriteLine($"Last Name: {contact.lastName}");
            Console.WriteLine($"Address: {contact.address}");
            Console.WriteLine($"Postal Code: {contact.postalCode}");
            Console.WriteLine($"Town: {contact.town}");
            Console.WriteLine($"Phone: {contact.phone}");
            Console.WriteLine($"Email: {contact.email}");
        }
    }

    if(userInput.Equals("E") || userInput.Equals("e"))
    {
        exitCondition = true;
    }

}


