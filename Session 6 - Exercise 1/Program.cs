/*
  Opgave 1 + 2:
  Placer alle metoder fra Opgave sættet Metoder i en classe MainHelper.
  Kald metoderne fra Program.cs
*/

// 1. Opsætter using, så program.cs den kan finde MainHelper.cs og MyCalc.cs
using Session_6___Exercise_1;
using Session_6___Exercise_1.UiHelper;

// 2. Deklarere en variabel mainhelper af datatypen MainHelper, der tildeles en instans af MainHelper, så vi kan bruge dents metoder
MainHelper mainHelper = new MainHelper();


// methods exercise 1
mainHelper.Print();

mainHelper.PrintExtraLine();

// methods exercise 2
Console.WriteLine($"{mainHelper.AddTwoNumbers(2, 2)} \n");

// methods ecercise 3
Console.WriteLine($"{mainHelper.DivideTwoNumbers(2,2)} \n");

// methods exercise 4
Console.WriteLine($"{mainHelper.InAgeRange(50)} \n");

// methods exercise 5
List<string> splitString = mainHelper.ReturnStringAsList("C# er et fantastisk sprog!");
for(int i = 0; i < splitString.Count; i++)
{
    Console.WriteLine(splitString[i]);
}

mainHelper.PrintExtraLine();

// methods exercise 6
int[] myNumbers = {1,2,3,4,5};

double numberResult = mainHelper.AvgMyNumbers(myNumbers);
Console.WriteLine($"{numberResult}");

// methods exercise 7
string[] myStrings = new string[5];

string stringResult = mainHelper.ConcenateMyStrings(myStrings);
Console.WriteLine(stringResult);

// methods exercise 8
mainHelper.AddValue1(5);

mainHelper.PrintExtraLine();

/*
 Opgave 3 + 4:
 Opret en classe MyCalc i en mappe UiHelper
 Opret disse fire metoder. Hvis parametre er negative returneres 0
 • Der tages imod to tal og returnere summen.
 • Der tages imod to tal og returnere tal1 minus tal2.
 • Der tages imod et tal og der returneres en værdi der angiver om tallet er et lige eller ulige tal
 • Der tages imod to tal og returnere tal1 ganget med tal2.
 Kald metoderne fra program.cs og udskriv en fejl hvis den returnerede værdi er 0, ellers resultatet
*/

// 1. opret en instans af MyCalc kaldet mycalc
MyCalc myCalc = new MyCalc();

// AddNUmbers method
int addNum1 = 2; int addNum2 = 4;

int addNumbersResult = myCalc.AddNumbers(addNum1,addNum2);

Console.WriteLine($"The result of adding {addNum1} and {addNum2} is: {addNumbersResult} \n");


// Num1MinusNUm2 method
int num1 = 2; int num2 = 4;

int num1Minusnum2Result = myCalc.Num1MinusNum2(num1, num2);

switch(num1Minusnum2Result)
{
    case 0:
        Console.WriteLine($"Error \n");
            break; ;

    default:
        Console.WriteLine($"The result of {num1} minus {num2} is: {num1Minusnum2Result} \n");
        break;
}

// IsEvenOrOdd method
bool isEvenOrOddResult = myCalc.IsEvenOrOdd(10);

if(isEvenOrOddResult.Equals(false))
{
    Console.WriteLine($"Number is {isEvenOrOddResult} \n");
} else
{
    Console.WriteLine($"Number is {isEvenOrOddResult} \n");
}

// MultiplyNum1Num2 method
int multiplyNum1 = 2;
int multiplyNum2 = 4;

int multiplyNum1Num2 = myCalc.MultiplyNum1Num2(multiplyNum1,multiplyNum2);

Console.WriteLine($"Multiplying {multiplyNum1} with {multiplyNum2} is: {multiplyNum1Num2}");





