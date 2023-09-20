/* 
  Opgave 6:Opret en metode der tager et array(5 eller flere) af tal
  og returnere gennemsnittet 
*/


int[] myNumbers = new int[5];

Console.WriteLine("Enter 5 integers, and I will return the average\n");

for (int i = 1; i < myNumbers.Length + 1; i++)
{
    Console.WriteLine($"Enter number {i}: ");
    myNumbers[i - 1] = int.Parse(Console.ReadLine());
    Console.WriteLine($"index {i} is now populated with {myNumbers[i -1]}");

}


double result = AvgMyNumbers(myNumbers);
Console.WriteLine(result);

double AvgMyNumbers(int[] myArray)
{

   double result = myArray.Sum() / myArray.Length;
    return result;
}


