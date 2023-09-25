/*
 Opgave 8: Opret to metoder (AddValue1, AddValue2) der tager et tal som parameter. 
 Program.cs må kalde AddValue1 og AddValue1 må kalde AddValue2. 
 Hver metoder adder 10 til det oprindelige tal.
*/

AddValue1(5);

void AddValue1 (int a)
{
    int result = a + 10;
    AddValue2(result);
}

void AddValue2 (int result)
{
    result = result + 10;
    Console.WriteLine(result);
}

