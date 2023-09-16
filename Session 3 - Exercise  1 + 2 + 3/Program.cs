/* Opgave 1: Opret console app der tager et input alder fra bruger. */

Console.WriteLine("Enter age: ");
string myAge = Console.ReadLine();


/* Opgave 2: converter til int og test tallet ikke er negativt */
int convertedAge = 0;

int.TryParse(myAge, out convertedAge);

if(convertedAge < 0)
{
  Console.WriteLine("Negative number - Enter age above 0");
}

/* 
   Opgave 3: Test om tallet er mindre end 13(Barn), fra 12 og mindre end 20(Teenager), 
   fra og med 20, til og med 67(Voksen) og alle andre pensionister. 
   Udskriv resultat. Lav en løsning der bruger If og en der bruger switch
*/

// If sætning
if (convertedAge < 13)
{
    Console.WriteLine($"You entered {convertedAge} you are a Child");
}
else if (convertedAge >= 12 && convertedAge < 20)
{
    Console.WriteLine($"You entered {convertedAge} you are a Teenager");
}
else if (convertedAge >= 20 && convertedAge <= 67)
{
    Console.WriteLine($"You entered {convertedAge} congrate you are an adult");
}
else if (convertedAge > 67)
{
    Console.WriteLine($"You entered {convertedAge} you are a pensioner");
}
else 
{ 
    Console.WriteLine("not in test range"); 
}

// Switch
switch(convertedAge)
{ 
    case < 13:
        Console.WriteLine($"You entered {convertedAge} you are a child");
        break;
    case >= 12 and > 20:
        Console.WriteLine($"You entered {convertedAge} you are a teen");
        break;
    case >= 20 and <= 67:
        Console.WriteLine($"You entered {convertedAge} you are a adult");
        break;
    default:
        Console.WriteLine("You are a Pensioner");
        break;
}



