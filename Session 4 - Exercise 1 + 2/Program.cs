/* Opgave 1: Opret et string array med 5 elementer */

string[] myArray = { "Poul", "Bob", "Louise", "Karen", "Bo" };



/* Opgave 2: Udskriv det med de 3 forskellige loops. */

// while loop
int counter1 = 0;

while (counter1 < myArray.Length)
{
    Console.WriteLine($"Printing from While-loop: {myArray[counter1]}");
    counter1++;
}

// For loop
for (int i = 0; i <  myArray.Length; i++)
{
    Console.WriteLine($"Printing from For-loop: {myArray[i]}");


}

// Do while
int counter2 = 0;

do
{
    Console.WriteLine($"Printing from -While: {myArray[counter2]}");
    counter2++;
} while (counter2 < myArray.Length);


