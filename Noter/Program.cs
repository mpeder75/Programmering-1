/*
 
 Methods skal ses som en funktion eller et underprogram.

 Methods gør at metoden kan genbruges gang efter gang.

 Methods kan enten returnere værdier, 
 eller blot afvikle instruktioner uden at returnere noget.


 Uden returnering:

 void <metodenavn> (argument)
 
  
 Med returnering (HUSK der skal angives returtype i metode decleration)
 
 int addTwoNum (num1, num2)

 */

/*
// Eks: tæl til 5 ad 3 gange

for(int i = 0; i < 3; i++)
{
    tæl();
}

void tæl()
{
    for(int i = 1; i < 6; i++)
    {
        Console.WriteLine(i);
    }
}

// Eks.: med argument som passes til funktion

for(int x = 0; x < 3; x++)
{
    tæl2(5);
}

void tæl2 (int x)
{
    for(int i = 1; i < 6; i++)
    {
        Console.WriteLine(i);
    }
}
*/

// Eks.: metodekald med argumenter

tæl3(5, 3);

void tæl3 (int tælTil, int gentag)
{
    for (int x = 1; x < gentag + 1; x++)
    {
        for (int i = 1; i < tælTil + 1; i++)
        {
            Console.WriteLine(i);
        }
    }
}









