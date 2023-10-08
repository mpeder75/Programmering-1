
// Håndtere at to tal ikke kan divideres med 0 eller at der divideres med bogstav

bool exitCondition = false;

while (!exitCondition)
{
    try
    {
        // kode der kan smide en exception placeres i try

        Console.WriteLine("Enter a number");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter another number");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > 0 && num2 >= 0)
        {
            Console.WriteLine($"The result is: {num1 / num2}");
            Console.WriteLine("Exiting program...");
            exitCondition = true;
        }
        else
        {
            Console.WriteLine("Both numbers must be positive");
        }
    }

    catch (DivideByZeroException e)
    {
        Console.WriteLine("Error " + e.Message);
    }
    catch (FormatException e)
    {
        Console.WriteLine("Error" + e.Message);
    }
}



