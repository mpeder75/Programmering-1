//todo Methods ekan ses som et unnderprogram eller funktion
//todo Methods staves ALTID med stort forbogstav 

// Syntax: [access modifier] [static] [returtype] Navn (argumenter)


// Method der bruger et loop til at printe 0-4 ud 3 gange

for(int i = 0; i < 3; i++)
{
    Tæl(5);
}

void Tæl(int tælTil)
{
    for(int i= 0; i < tælTil; i ++)
    {
        Console.WriteLine(i);
    }
}


// Samme method men mere enkelt

Tæller(5, 5);   

void Tæller(int tælTil, int hvorMangeGange)
{
    for (int x = 0; x < hvorMangeGange; x++)
    {
        for(int i = 0; i < tælTil; i++ )
        {
            Console.WriteLine(i);
        }
    }
}


// --------------- Metoder der IKKE retuurnere --------------- //

MinMetode1();
MinMetode2("Poul",55);


static void MinMetode1()
{
    Console.WriteLine("Hello from method 1");
}

static void MinMetode2(string name, int age) {
    Console.WriteLine($"Hello {name}, you are {age} old ");
}

static void MinMetode3(int a, string b)
{
    if(a < 5)
    {
        return;
    }
    Console.WriteLine($"Her er {a} > 5 og b printes blot: {b}");
}


// --------------- Metoder der returnere værdier --------------- //

Method1();
bool r1 = Method1();
Console.WriteLine(Method1());

bool r2 = Method2(1);
Console.WriteLine(r2);

int r3 = Method3(3, 5);
Console.WriteLine(r3);

string myName = Method4("michael");
Console.WriteLine(myName);




static bool Method1()
{
    return true;
}

static bool Method2(int a)
{
    bool res = a > 10;
    return res;
}

static int Method3(int a, int b)
{
    return a + b;
}


static string Method4(string navn)
{
    if(navn == null || navn.Equals(""))
    {
        return "";
    }

    string navnMedSmåBogstaver = navn.ToLower();
    string førsteBogstavINavn = navnMedSmåBogstaver.Substring(0, 1).ToUpper();
    string restenAfNavn = navnMedSmåBogstaver.Substring(1);
    
    return førsteBogstavINavn + restenAfNavn;
}
