/* Opgave 7: Bed bruger om at indtaste:

    • Alder
    • Fornavn
    • Efternavn
    • Email

Test om variabler er valide

Krav:

    • Alder fra 0-120
    • Fornavn/efternavn skal have en begrænsning på 2-50 chars
    • Email skal indeholde et @ 
    • Email skal indeholde mindst 2 chars efter @
    • Email skal indeholde mindst 2 chars før @

HVIS værdier ikke er valide SKAL bruger presses til at indtaste korrekte værdier
*/

// Alder angives, og der tjekkes om den er indefor range
using System.IO;

Console.WriteLine("Enter age (0-120): ");
string ageString = (Console.ReadLine());

int age;
bool success = int.TryParse(ageString, out age);

while(!success)
{
    Console.WriteLine("Age needed, please enter age 0-120: ");
    ageString = Console.ReadLine();
    success = int.TryParse(ageString, out age);
}

// firstname
for(;;)
{
    Console.WriteLine("Enter first name (2-50 chars long): ");
    string firstName = Console.ReadLine();
    
    if (firstName.Length >= 2 && firstName.Length <= 50)
    {
        Console.WriteLine($"Nice to meet you {firstName}");
        break;
    } else
    {
        Console.WriteLine("First name needs to be 2-50 char long, try again: ");
    }
}


// lastname
while(true)
{
    Console.WriteLine("Whats your last name (2-50 chars long): ");
    string lastName = Console.ReadLine();

    if(lastName.Length >= 2 && lastName.Length <= 50)
    {
        Console.WriteLine($"Nice, I really like your last name: {lastName}");
        break;
    } else
    {
        Console.WriteLine("Oops, lastname needs to be 2-50 chars, try again: ");
    }
}

// email
for (;;)
{
    Console.WriteLine("Enter email: ");
    string email = Console.ReadLine();

    // 1. tjek om email string er tom
    if(string.IsNullOrEmpty(email))
    {
        Console.WriteLine("No email entered, please try again: ");
        // continue gør at der hoppes retur til "hoved" loopet igen HVIS string er tom, og bruger skal indtaste igen
        continue;
    }

    // 2. indexet af placeringen af @ findes i string, og lægges i variabl
    int snabelAIndex = email.IndexOf('@');

    // 3. hvis der IKKE er et @, vil det tal der lægges i int variablen snabelAIndex være negativt 
    if(snabelAIndex == -1)
    {
        Console.WriteLine("woops, no @ in your email adress, try agein: ");
        continue;
    }

    // 3.
    // snabelAIndex < 2 ---> Denne tjekker om der er 2 indexes(pladser foran @ i email
    if (snabelAIndex < 2 || snabelAIndex >= email.Length - 2)
    {
        Console.WriteLine("Woops, looks like your email is too short, username min. 2 char");
        Console.WriteLine("Please enter email: ");
        continue;
    }


}




