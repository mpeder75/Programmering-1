/* 
 Opret en metode der tager to tal og returnere det første delt med 
 det andet. Du skal sikre dig at begge tal er større end 0 og at første 
 tal1 er større end tal2 
 */

DivideTwoNumbers(10,20);

int DivideTwoNumbers(int a, int b)
{
    if((a > 0 && b > 0) && a > b)
    {
        return a / b;
    } else
    {
        return -1;
    }
}