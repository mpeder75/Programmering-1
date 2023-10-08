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


string userFirstName = "";
string userLastName = "";
string userAddress = "";
string userTown = "";
int userPostalCode = 0;
string userEmail = "";
int userPhoneNumber = 0;

bool exitCondition = false;
string userInput = "";

Console.WriteLine("****************************************************");
Console.WriteLine($"\tWelcome to UCL Vejle Contact manager");
Console.WriteLine("****************************************************");

DateTime date = DateTime.Now;
Console.WriteLine($"Date is: {date}\n");

PersonDb personDb = new PersonDb();

while (!exitCondition)
{
    Console.WriteLine("MENU:");
    Console.WriteLine("[C]reate contact");
    Console.WriteLine("[P]rint contacts");
    Console.WriteLine("[E]xit application\n");
    Console.WriteLine("Please enter your choice");
    userInput = Console.ReadLine();
    int num = 0;

    if (userInput.Equals("C") || userInput.Equals("c"))
    {

        Random rnd = new Random();
        num = rnd.Next();

        try
        {
            bool condition = false;

            while (!condition)
            {
                Console.WriteLine("Enter first name:");
                userFirstName = Console.ReadLine();

                if (string.IsNullOrEmpty(userFirstName))
                {
                    Console.WriteLine("First name cannot be empty!");
                }
                else
                {
                    bool containsNumbers = false;

                    for (int i = 0; i < userFirstName.Length; i++)
                    {
                        if (char.IsDigit(userFirstName[i]))
                        {
                            containsNumbers = true;
                            break;
                        }
                    }

                    if (containsNumbers)
                    {
                        throw new Exception("Number in name not allowed!");
                    }
                    else
                    {
                        Console.WriteLine($"First name {userFirstName} created");
                        condition = true;
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            while (true)
            {

                Console.WriteLine("Enter a valid first name:");
                userFirstName = Console.ReadLine();

                if (!string.IsNullOrEmpty(userFirstName) && !userFirstName.Any(char.IsDigit))
                {
                    Console.WriteLine($"First name {userFirstName} created");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid first name. Number in name not allowed.");
                }
            }
        }

        try
        {

            bool condition = false;

            while (!condition)
            {
                Console.WriteLine("Enter last name:");
                userLastName = Console.ReadLine();

                if (string.IsNullOrEmpty(userLastName))
                {
                    Console.WriteLine("Last name cannot be empty!");
                }
                else
                {
                    bool containsNumbers = false;

                    for (int i = 0; i < userLastName.Length; i++)
                    {
                        if (char.IsDigit(userLastName[i]))
                        {
                            containsNumbers = true;
                            break;
                        }
                    }

                    if (containsNumbers)
                    {
                        throw new Exception("Number in last name not allowed!");
                    }
                    else
                    {
                        Console.WriteLine($"Last name: {userLastName} created");
                        condition = true;
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            while (true)
            {

                Console.WriteLine("Enter a valid last name:");
                userLastName = Console.ReadLine();

                if (!string.IsNullOrEmpty(userLastName) && !userLastName.Any(char.IsDigit))
                {
                    Console.WriteLine($"Last name {userLastName} created");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid last name. Number in last name not allowed.");
                }
            }
        }

        try
        {
            bool condition = false;

            while (!condition)
            {
                Console.WriteLine("Enter address:");
                userAddress = Console.ReadLine();

                if (string.IsNullOrEmpty(userAddress))
                {
                    Console.WriteLine("Address cannot be empty!");
                }
                else
                {
                    bool containsNumbers = false;

                    for (int i = 0; i < userAddress.Length; i++)
                    {
                        if (char.IsSymbol(userAddress[i]))
                        {
                            containsNumbers = true;
                            break;
                        }
                    }

                    if (containsNumbers)
                    {
                        throw new Exception("Symbol in adress not allowed!");
                    }
                    else
                    {
                        Console.WriteLine($"Address {userAddress} created");
                        condition = true;
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            while (true)
            {

                Console.WriteLine("Enter a valid address:");
                userAddress = Console.ReadLine();

                if (!string.IsNullOrEmpty(userAddress) && userAddress.Any(char.IsSymbol))
                {
                    Console.WriteLine("Invalid address name. Symbol in address not allowed.");

                }
                else
                {
                    Console.WriteLine($"Address {userAddress} created");
                    break;
                }
            }
        }


        try
        {
            bool condition = false;

            while (!condition)
            {
                Console.WriteLine("Enter your town:");
                userTown = Console.ReadLine();

                if (string.IsNullOrEmpty(userTown))
                {
                    Console.WriteLine("Town name cannot be empty!");
                }
                else
                {
                    bool containsNumbers = false;

                    for (int i = 0; i < userTown.Length; i++)
                    {
                        if (char.IsDigit(userTown[i]))
                        {
                            containsNumbers = true;
                            break;
                        }
                    }

                    if (containsNumbers)
                    {
                        throw new Exception("Number in town name not allowed!");
                    }
                    else
                    {
                        Console.WriteLine($"Town name {userTown} created");
                        condition = true;
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            while (true)
            {

                Console.WriteLine("Enter a valid town:");
                userTown = Console.ReadLine();

                if (!string.IsNullOrEmpty(userTown) && !userTown.Any(char.IsDigit))
                {
                    Console.WriteLine($"Twn: {userTown} created");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid town name. Number in town name not allowed.");
                }
            }
        }



        try
        {
            bool postalCodeValid = false;

            while (!postalCodeValid)
            {
                Console.WriteLine("Enter postal code:");
                string postalCodeInput = Console.ReadLine();

                if (string.IsNullOrEmpty(postalCodeInput))
                {
                    Console.WriteLine("Postal code cannot be empty!");
                }
                else if (!int.TryParse(postalCodeInput, out userPostalCode))
                {
                    Console.WriteLine("Invalid postal code. Postal code must contain only numbers!");
                }
                else
                {
                    Console.WriteLine($"Postal code {userPostalCode} created");
                    postalCodeValid = true;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            while (true)
            {
                Console.WriteLine("Enter a valid postal code:");
                string postalCodeInput = Console.ReadLine();

                if (string.IsNullOrEmpty(postalCodeInput))
                {
                    Console.WriteLine("Postal code cannot be empty!");
                }
                else if (!int.TryParse(postalCodeInput, out userPostalCode))
                {
                    Console.WriteLine("Invalid postal code. Postal code must contain only numbers!");
                }
                else
                {
                    Console.WriteLine($"Postal code {userPostalCode} created");
                    break;
                }
            }
        }

        try
        {
            bool condition = false;

            while (!condition)
            {
                Console.WriteLine("Enter valid email:");
                userEmail = Console.ReadLine();

                if (string.IsNullOrEmpty(userEmail))
                {
                    Console.WriteLine("Email cannot be empty!");
                }
                else
                {
                   Console.WriteLine($"Email: {userEmail} created");
                   condition = true;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            while (true)
            {

                Console.WriteLine("Enter a email:");
                userEmail = Console.ReadLine();

                if (string.IsNullOrEmpty(userEmail))
                {
                    Console.WriteLine("Email cannot be empty!");
                }
                else
                {
                    Console.WriteLine($"Email: {userEmail} created");
                    break; 
                }
            }
        }


        try
        {
            bool userPhoneValid = false;

            while (!userPhoneValid)
            {
                Console.WriteLine("Enter phone number:");
                string userPhoneNumberInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userPhoneNumberInput))
                {
                    Console.WriteLine("Phone number cannot be empty!");
                }
                else if (!int.TryParse(userPhoneNumberInput, out userPhoneNumber))
                {
                    Console.WriteLine("Invalid phone number. Phone number must contain only numbers!");
                }
                else
                {
                    Console.WriteLine($"Phone number: {userPhoneNumber} created");
                    userPhoneValid = true;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            while (true)
            {
                Console.WriteLine("Enter a valid phone number:");
                string userPhoneNumberInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userPhoneNumberInput))
                {
                    Console.WriteLine("Phone number cannot be empty!");
                }
                else if (!int.TryParse(userPhoneNumberInput, out userPhoneNumber))
                {
                    Console.WriteLine("Invalid phone number. Phone number must contain only numbers!");
                }
                else
                {
                    Console.WriteLine($"Phone number: {userPhoneNumber} created");
                    break;
                }
            }
        }
                
        Contact newContact = new Contact (
            num,
            userFirstName,
            userLastName,
            userAddress,
            userPostalCode,
            userTown,
            userPhoneNumber,
            userEmail
        );

        personDb.AddContacts(new List<Contact> { newContact });
        Console.WriteLine("Contact created\n");
    }


    if (userInput.Equals("P") || userInput.Equals("p"))
    {
        List<Contact> contacts = personDb.ReturnContacts();

        for (int i = 0; i < contacts.Count; i++)
        {
            Contact contact = contacts[i];

            Console.WriteLine($"ID: {contact.Id}");
            Console.WriteLine($"First Name: {contact.FirstName}");
            Console.WriteLine($"Last Name: {contact.LastName}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine($"Postal Code: {contact.PostalCode}");
            Console.WriteLine($"Town: {contact.Town}");
            Console.WriteLine($"Phone: {contact.Phone}");
            Console.WriteLine($"Email: {contact.Email}");
        }
    }

    if (userInput.Equals("E") || userInput.Equals("e"))
    {
        exitCondition = true;
    }
}








