
// method kaldes, uden at passe et moms beløb, da det er en default værdi i method
double resultat1 = BeregnPrisMedMoms(100);

// metohs kaldes, men her passes et højere mom beløb med ind
// compiler vil udskifte 0.25 i method med 0.50
double resultat2 = BeregnPrisMedMoms(100, 0.50);

Console.WriteLine(resultat1);
Console.WriteLine(resultat2);


static double BeregnPrisMedMoms(double pris, double moms = 0.25)
{
    return pris * (1 + moms);
}