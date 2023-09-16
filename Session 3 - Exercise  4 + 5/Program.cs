/* Opgave 4: Opret consol app der tager et input måned fra bruger. */

Console.WriteLine("Enter month 1-12");
int monthNumber = int.Parse(Console.ReadLine());



/* 
    Opgave 5: Brug nu en switch til at teste om et tal et tal er:
    1(Januar)
    2(Februar)...
    Default(Forkert input!!!)
*/

    switch (monthNumber)
{
    case 1:
        {
            Console.WriteLine("January");
            break;
        }
    case 2:
        {
            Console.WriteLine("Febuary");
            break;
        }
    case 3:
        {
            Console.WriteLine("March");
            break;
        }
    case 4:
        {
            Console.WriteLine("April");
            break;
        }
    case 5:
        {
            Console.WriteLine("May");
            break;
        }
    case 6:
        {
            Console.WriteLine("June");
            break;
        }
    case 7:
        {
            Console.WriteLine("July");
            break;
        }
    case 8:
        {
            Console.WriteLine("August");
            break;
        }
    case 9:
        {
            Console.WriteLine("September");
            break;
        }
    case 10:
        {
            Console.WriteLine("October");
            break;
        }
    case 11:
        {
            Console.WriteLine("November");
            break;
        }
    case 12:
        {
            Console.WriteLine("December");
            break;
        }
    default:
        {
            Console.WriteLine("Not a valid month integfer");
            break;
        }
}   