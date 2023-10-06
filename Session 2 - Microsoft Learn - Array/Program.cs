//todo Array er en sekvens af data


// 1a. declare et array med 5 pladser - Long hand notation
int[] numbers = new int[5];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

Console.WriteLine(numbers[1].ToString());


// 1b. declare et array med 5 pladser - Short hand notation
int[] myNumbers = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine(myNumbers[1].ToString());


// 2. string array der opbevare navne
string[] names = new string[] { "Eddie", "Paul", "Michael", "Charles", "John" };

// foreach itere igennem names, og for hvert iteration gemmes det i variablen name
foreach (var name in names)
{
    Console.WriteLine(name);
}

// for-loop
for(int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

// while
int counter = 0;
while(counter < names.Length)
{
    Console.WriteLine(names[counter]);
    counter++;
}


// 3. Reverse et array
string zig = "You can get wjat you want " +
             "out of life if you help people get what they want";

// zip string konverteres til char array med ToCharArray() og gemmeis i charArray
char[] charArray = zig.ToCharArray();
// hvert element i charArray placeres baglæns
Array.Reverse(charArray);

foreach(char chararray in charArray)
{
    Console.WriteLine(chararray);
}

// hvor mange elementer er i array
Console.WriteLine(numbers.Length);