/*
  
Variable Assignment:
Declare two integer variables, assign them values, and then print their sum.
*/

int a = 5;
int b = 10;

int c = a + b;

/*
Conditional Statement:
Write a program that checks if a given number is even or odd and prints the result.
*/

/*
for (;;) 
{
    Console.WriteLine("Enter a number");
    int myNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("Press 'E' to exit program");
    string exit = Console.ReadLine();

    if (myNumber % 2 == 0)
    {
        Console.WriteLine($"Number {myNumber} is even");
    }
    else if (!(myNumber % 2 == 0))
    {
        Console.WriteLine($"Number {myNumber} is odd");
    }

    if (exit.ToUpper() == "E")
    {
        break;
    }
}
*/


/*
Loop - For:
Use a for loop to print all the even numbers from 1 to 10.
*/

for(int i = 0; i < 10; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    } 
}

Console.WriteLine();

/*
Loop - While:
Use a while loop to print the numbers from 1 to 5.
*/

int counter = 1;
while(counter < 6)
{
    Console.WriteLine($"Printing from while: {counter}");
    counter++;
}


/*
Loop - Do-While:
Use a do-while loop to ask the user to enter a number, and keep asking until they enter the number 42. Print "You found the answer!" when they enter 42.
*/

do
{

} while (true);

/*
Simple Calculator:
Write a program that takes two numbers and an operator (+, -, *, /) as input from the user and performs the corresponding operation, then displays the result.

Factorial Calculator:
Write a program that calculates the factorial of a given number using a loop.

Guess the Number:
Generate a random number between 1 and 100. Ask the user to guess the number and provide hints (higher or lower) until they guess correctly.

Sum of Numbers:
Write a program that asks the user for a positive integer n and calculates the sum of all integers from 1 to n.

Multiplication Table:
Print the multiplication table for a given number (e.g., the table for 5: 5 x 1 = 5, 5 x 2 = 10, and so on).
*/