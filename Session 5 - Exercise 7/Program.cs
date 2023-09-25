/*
 Opgave 7: Opret en metode der tager et array(5 eller flere) af tekst og 
 returnere en sammensatstringder indeholder alle værdierne fra arrayet
*/


string[] myStrings = new string[5];

Console.WriteLine("Enter 5 strings, and I will concenate it to one string ❤️\n");

for (int i = 1; i < myStrings.Length + 1; i++)
{
    Console.WriteLine($"Enter string {i}: ");
    myStrings[i - 1] = Console.ReadLine();
    Console.WriteLine($"index {i} is now populated with {myStrings[i - 1]}\n");

}


string result = concenateMyStrings(myStrings);
Console.WriteLine(result);

string concenateMyStrings(string[] myArray)
{

    string result = "";
    for(int i = 0; i < myArray.Length; i++)
    {
        result += myArray[i] + " ";
    }

    return result;
 }


