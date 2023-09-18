/* Opgave 2: 
   Opret en metode der tager to tal og returnere om disse er lig med hinanden. 
   Vælg hensigtsmæssig returværdi
*/


AddTwoNumbers(5,5);


string AddTwoNumbers(int a, int b)
{

    if(a == b)
    {
        return $"Num1: {a} is equal to Num2: {b}";
    } else
    {
        return $"Num1: {a} is NOT equal to Num2: {b}";
    }
}