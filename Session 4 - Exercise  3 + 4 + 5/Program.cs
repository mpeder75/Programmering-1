/* Opgave 3: Opret 2 int arrays med plads til 5 elementer */

int[] myArray1 = new int[5];
int[] myArray2 = new int[5];




/* Opgave 4: Brug For loop til at fylde den ene med 5-4-3-2-1 */

// starter i index 4, loop iterere ned fra 4 til 0
for (int i = 0; i < myArray1.Length; i++)
{
    myArray1[i] += 5 - i;  // her tilføjes 5 til hver iteration MINUS iterationsnummeret 
}                          // i = 0 -> 5 - i[0] = 5 
                           // i = 1 -> 5 - i[1] = 4
                           // i = 2 -> 5 - i[2] = 3
                           // i = 3 -> 5 - i[3] = 2
                           // i = 4 -> 5 - i[4] = 1
                           // i = 5 -> 5 - i[5] = 0

for (int i = 0; i < myArray1.Length; i++)
{
    Console.WriteLine($"Printing {myArray1[i]}");
}


Console.WriteLine();



/* Opgave 5: Brug While loop til fylde den anden med 1-2-3-4-5 */

int counter = 1;
int index = 0;

while (counter <= myArray2.Length)
{
    myArray2[index] = myArray2[index] + counter;
    counter++;
    index++;
}

for (int i = 0; i < myArray2.Length; i++)
{
    Console.WriteLine($"Printing {myArray2[i]}");
}

