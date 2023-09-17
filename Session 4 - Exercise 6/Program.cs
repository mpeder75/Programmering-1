/* Opgave 6: Lav opgave 1-5 og brug List i stedet for array */



/* Opgave 6.1: Opret et string array med 5 elementer */
using System.Net.Http.Headers;

List<string> stringList = new List<string> { "Tøfting", "Laudrup", "Pele", "Shearer", "Bierhoff" };



/* Opgave 6.2: Udskriv det med de 3 forskellige loops. */  

// for-loop
for (int i = 0; i < stringList.Count; i++)
{
    Console.WriteLine($"Printing from for-loop: {stringList[i]}");
}

Console.WriteLine();

// while-loop
int counter = 0;
while(counter < stringList.Count) 
{
    Console.WriteLine($"Printing from while-loop: {stringList[counter]}");
    counter++;
}

Console.WriteLine();

// do-while
int incrementer = 0;
do
{
    Console.WriteLine($"Printing from do-while: {stringList[incrementer]}");
    incrementer++;
} while (incrementer < stringList.Count);



/* Opgave 6.3: Opret 2 int lists med plads til 5 elementer */

List<int> intList1 = new List<int>();
List<int> intList2 = new List<int>();

Console.WriteLine();



/* Opgave 6.4: Brug for loop til at fylde den ene list med 5-4-3-2-1 */
for (int i = 0; i < 5; i++)
{
    intList1.Add(i);
    Console.WriteLine($"Printing from list & for-loop: {intList1[i]}");
}

Console.WriteLine();

/* Opgave 6.5: Brug for while loop til at fylde den anden med 1-2-3-4-5 */

int counter2 = 0;
while (counter2 < 5) 
{
    intList2.Add(counter2);
    Console.WriteLine($"Printing from List & while-loop: {intList2[counter2]}");
    counter2++;
}





