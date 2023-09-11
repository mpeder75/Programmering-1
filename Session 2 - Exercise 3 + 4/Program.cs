/* Opgave 3: Opret et array der indeholder 10 tal */

// Declare variabel myIntArray af datatypen int[] der assignes 10 int værdier
int[] myIntArray = {1,2,3,4,5,6,7,8,9,10};

// Tjek om array har en længde af 10
Console.WriteLine($"Længde af array : {myIntArray.Length} indexes");



// -------------------------------------------------------------------------- //

/* Opgave 4: Læg tallene på indeks 1,3,5,8 sammen */

int sum = myIntArray[1] + myIntArray[3] + myIntArray[5] + myIntArray[8];
Console.WriteLine($"\nSummen af værdier i index {myIntArray.GetValue(0)}, {myIntArray.GetValue(2)}, {myIntArray.GetValue(4)}, {myIntArray.GetValue(7)} = {sum}");
Console.WriteLine($"\nSummen af int værdier i hele array = {myIntArray.Sum()}");