/* 
 Opret en metode der tager et tal som parameter. 
 Test om tallet er mindre end 13(Barn), mellem 12 og 20(Teenager), 
 fra og med 20 til og med 67(Voksen) og alle andre pensionister. 
 Returner resultat som tekst. 
*/


string result = InAgeRange(20);
Console.WriteLine(result);

string InAgeRange(int a)
{
    if (a < 13)
    {
        return $"age = {a}, you are a child";
    }
    else if (a >= 12 && a < 20)
    {
        return $"age = {a}, you are a teen";
    }
    else if (a >= 20 && a <= 67)
    {
        return $"age = {a}, you are a adult";
    }
    else if (a > 67)
    {
        return $"age = {a}, you are a pensioner";
    } else
        return "not in age range";
}


    


  