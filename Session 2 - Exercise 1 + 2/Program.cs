/* Opgave 1: Opret et array der kan indeholde fem ord */

// Første version
string[] myArray1 = new string[5];

myArray1[0] = "Abe";
myArray1[1] = "Krokodille";
myArray1[2] = "Hest";
myArray1[3] = "Mus";
myArray1[4] = "Kat";

// Anden Version
string[] myArray2 = {"Poul", "Louise", "Sofie", "Anders", "Josephine"};


// Tredje Version
string[] myArray3 = new string[] {"Signe", "Hans", "Trine", "Tim", "Bo"};



// -------------------------------------------------------------------------- //

/* Opgave 2: Udskriv 3 og 5 ord */

Console.WriteLine($"3 ord : {myArray1[2]} - 5 ord : {myArray1[4]}");

Console.WriteLine($"3 ord : {myArray1[^3]} - 5 ord : {myArray1[^1]}");




