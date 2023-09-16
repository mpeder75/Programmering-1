/* Opgave 6: Opret en app der tager følgendne parametre:
    • Fornavn
    • Efternavn
    • Titel
    • Adresse
    • Postnummer
    • By
    • Tlf.
    • Email

Prøv at konverter til de korrekte værdier og test om det lykkedes. 

For Email gælder at der testes på om den indeholder @
*/

Console.WriteLine("Enter firstname: ");
string firstName = Console.ReadLine();

Console.WriteLine("Enter lastname: ");
string lastName = Console.ReadLine();

Console.WriteLine("Enter title: ");
string title = Console.ReadLine();

Console.WriteLine("Enter address: ");
string address = Console.ReadLine();

Console.WriteLine("Enter postalcode: ");
int postalCode = int.Parse(Console.ReadLine());

Console.WriteLine("Enter City: ");
string city = Console.ReadLine();

Console.WriteLine("Enter phonenumber: ");
int poneNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter email: ");
string email = Console.ReadLine();


if(!(email.Contains('@'))) {
    Console.WriteLine($"Invalid email format, nedde to contain @");
} else if(true)
{
    Console.WriteLine($"\nHello {firstName} {lastName}\nYour adress is: {address}" +
        $"\nLocated in the city of: {city} and your postalcode is: {postalCode}" +
        $"\nPhone number entered is: {poneNumber}\nEmail entered is: {email}\nAnd your title is: {title}");
}

