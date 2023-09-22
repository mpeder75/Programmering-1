/*
 Opgave 9: Opret en metode der tager en collection af tal. 
 Hvis det sidste tal er et lige tal returneres alle lige tal,
 hvis ulige returneres disse

  • Eks.1 List{1,2,3,4,5,6,7} 7 er et ulig tal og der returneres 1,3,5,7
  • Eks.2 List{1,2,3,4,5,6,7,8,9,10} 10 er et lige tal og der returneres 0,20,4,6,8,10
*/



// ---------------- Part 1 -------------------------------------------------- //

Console.WriteLine("Enter how many numbers the list should contain: ");
int listSize = int.Parse(Console.ReadLine());

List<int> numbersToCheck = new List<int>(listSize);

for (int i = 0; i < listSize; i++)
{
    Console.WriteLine($"Enter number {i + 1}: ");
    int number = int.Parse(Console.ReadLine());
    numbersToCheck.Add(number);
}

List<int> result = NumToValidate(numbersToCheck);

// ---------------- Part 2--------------------------------------------------- //

if (result.Count == 0)
{
    Console.WriteLine("No matching numbers found.");
}
else
{
    Console.WriteLine("Results:");
    Console.WriteLine(string.Join(", ", result));
}

// -------------------Part 3------------------------------------------------- //


List<int> NumToValidate(List<int> myList)
{
    int lastNumber = myList.Last();
    List<int> matchingNumbers = new List<int>();

    if (lastNumber % 2 != 0)
    {
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 != 0)
            {
                matchingNumbers.Add(myList[i]);
            }
        }
    }
    else
    {
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
            {
                matchingNumbers.Add(myList[i]);
            }
        }
    }
    return matchingNumbers;
}




/*
Console.WriteLine("Enter hvor many numbers the list should contain: ");
int listSize = int.Parse(Console.ReadLine());

List<int> numbersToCheck = new List<int>(listSize);

for (int i = 0; i < listSize; i++)
{
    Console.WriteLine($"Enter number {i + 1}: ");
    int number = int.Parse(Console.ReadLine());
    numbersToCheck.Add(number);
}

List<int> result = NumToValidate(numbersToCheck);

List<int> NumToValidate(List<int> myList)
{
    int lastNumber = myList.Last();
    List<int> matchingNumbers = new List<int>();

    if (lastNumber % 2 != 0)
    {
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 != 0)
            {
                matchingNumbers.Add(myList[i]);
            }
        }
    }
    else
    {
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
            {
                matchingNumbers.Add(myList[i]);
            }
        }
    }
    return matchingNumbers;
}
*/





