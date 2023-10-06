//todo Exception opstår når compiler får en datatype mismatch,
//todo reference der ikke kan tilgåes, altså et uventet problem når der cpmpiles.

//! ex. exception opstår når der skal læses fil fra hdd. men directory ikke findes

//! ex. tilgåe en database, og tabellen er slettet

/*
 Brug try/catch når:
 • Bruger skal inputte data
 • Filer skal tilgåes
 • Netværksresource skal tilgåes
*/

// Eksempel: Fil kan ikke findes på hdd //

try
{
    string filePath = @"c:\Demos\myTest.txt";

    File.ReadAllLines(filePath);
    List<string> lines = File.ReadAllLines(filePath).ToList();


    for (int i = 0; i < lines.Count; i++)
    {
        Console.WriteLine($"Printing from for-loop: {lines[i]}");
    }
}
catch(DirectoryNotFoundException e)
{
    // udføres hvis directory ikke eksistere
    Console.WriteLine($"Directory not found, are you sure directory exists?" );
}
catch(FileNotFoundException e)
{
    // udføres hvis fil ikke eksistere
    Console.WriteLine($"File not found, are you sure file exists?");
}
catch(Exception e)
{
    // Generel exception, hvis oveståendne ikke har fanget exception hvis den er af en anden type
    Console.WriteLine($"File path incorrect: {e.Message}");
}
finally
{
    // finally udføre instrukser der kan løse de exceptions der er fundet

}