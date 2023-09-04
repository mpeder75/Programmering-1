/*
Opret en konsolapp der lægger to tal sammen. 
Tallene skal du hente fra Console.ReadLine().  
*/

// Første tal aflæses og gemmes i string variabel num1, dernsæt parses den til en int og gemmes i variablen number1
Console.WriteLine("Indtast tal 1: ");
string num1 = Console.ReadLine();
int number1 = Int32.Parse(num1);

// Andet tal aflæses og gemmes i variabel 
Console.WriteLine("Indtast tal 2: ");
string num2 = Console.ReadLine();
int number2 = Int32.Parse(num2);

int sum = number1 + number2;



// Tal lægges sammen og printes ud
Console.WriteLine("Dine tal lægt sammen er: " + sum);
