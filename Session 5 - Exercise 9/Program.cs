/*
 Opgave 9: Opret en metode der tager en collection af tal. 
 Hvis det sidste tal er et lige tal returneres alle lige tal,
 hvis ulige returneres disse

  • Eks.1 List{1,2,3,4,5,6,7} 7 er et ulig tal og der returneres 1,3,5,7
  • Eks.2 List{1,2,3,4,5,6,7,8,9,10} 10 er et lige tal og der returneres 0,20,4,6,8,10
*/


Console.WriteLine("Enter hvor many numbers the list should contain: ");
int listSize = int.Parse(Console.ReadLine());

List<int> numbersToCheck = new List<int>(listSize);

for(int i = 0; i < listSize; i++)
{
    Console.WriteLine($"Enter number {i + 1}: ");
    int number = int.Parse(Console.ReadLine());
    numbersToCheck.Add(number);
}

numToCheck(numbersToCheck);

int numToCheck(List<int> myList)
{
    List<int> numberstoReturn = new List<int>();

    if(myList.Last() % 2 != 0)
    {
        for (int i = 0; i < myList.Count; i++)
        {
            int number = myList[i];
            numberstoReturn.Add(number);
            
        }
        
    } else if (myList.Last() % 2 == 0)
    {
        bool exitCondition = false;
        while (!exitCondition)
        {
            
        }
    }
    return -1;

} 















































/*
bool exitLoop = false;

while (!exitLoop)
{
    Console.WriteLine("How many numbers do you want in the list? (min 4): ");

    int listSize = int.Parse(Console.ReadLine());

    if (Console.ReadLine().Equals(""))
    {
        Console.WriteLine("Not a number, please enter INTEGER to specify List size: ");
        exitLoop = true; ;
    }
    else
    {
        listSize = int.Parse(Console.ReadLine());
        exitLoop = false;
    }

    if (listSize <= 4)
    {
        Console.WriteLine("List needs to be minimum 4\nEnter list size (min 4 long)");
    }
    else
    {
        exitLoop = true;
    }
}
*/

        










