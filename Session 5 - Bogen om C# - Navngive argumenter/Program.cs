
// standard kald af metode: hvor rækkefølge skal være korrekt
Metode1("Mikkel", 30, true, "Dk");

// kald til metode men med argumenter istedet
// nu behøver man ikke bruge en specifik rækkefølge
Metode1(land: "Dk", erSmart: true, alder: 16, navn: "Mikkel");


static void Metode1(string navn, int alder, bool erSmart, string land)
{
    Console.WriteLine( $"{navn} {alder} {erSmart} {land} ");
    
}