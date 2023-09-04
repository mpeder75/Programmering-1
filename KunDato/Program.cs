

// 1. Du skal oprette en variabel der genner datoen idag - Denne gennes i et objekt
var DateAndTime = DateTime.Now;

// 2. Her konverteres objektet til en string, som kan printes ud
var date = DateAndTime.Date.ToString("dd-MM-yyyy");

// 3. Her printer vi KUN dato ud
Console.WriteLine(date);