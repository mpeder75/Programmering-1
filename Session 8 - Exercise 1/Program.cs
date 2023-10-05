using Session_8___Exercise_1.Models;
using Session_8___Exercise_1.DataAccess;

string userName;
bool exitCondition = false;
while (!(exitCondition))
{
    Console.WriteLine("Would you like to create a Contact? [Y]es or [N]o");
    string userInput = Console.ReadLine();

    if(userInput.Equals("Y") || userInput.Equals("y"))
    {
        Console.WriteLine("Enter First Name");
        userName = Console.ReadLine();

        bool userNameContainsInteger = userName.Any(char.IsDigit);

        if(userNameContainsInteger == true)
        {
            Console.WriteLine("Name must not include any integers");
            Console.WriteLine("Enter First Name");
            userName = Console.ReadLine();
            exitCondition = true;
            
        } else
        {
            userName = Console.ReadLine();
            exitCondition = true;
        }
    } else if (userInput.Equals("N") || userInput.Equals("n"))
    {
        exitCondition = true;
    }
}

