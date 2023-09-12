/* Test om tallet er mindre end 13(Barn), fra 12 og mindre end 20(Teenager), fra og med 20, til og med 67(Voksen) og alle andre pensionister. 
   Udskriv resultat. 
   
Lav en løsning der bruger If og en der bruger switch 
*/

Console.WriteLine("Enter age: ");
string myAge = Console.ReadLine();

int convertedAge = 0;

int.TryParse(myAge, out convertedAge);

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
else { Console.WriteLine("not in test range"); }


