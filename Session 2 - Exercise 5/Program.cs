/*
 Opret et array [5,5] med 2 dimensioner, tildel hvert indeks et ord  
 */


string[,] my2DimensionalArray = new string[5, 5];

my2DimensionalArray[0, 0] = "1";
my2DimensionalArray[0, 1] = "2";
my2DimensionalArray[0, 2] = "3";
my2DimensionalArray[0, 3] = "4";
my2DimensionalArray[0, 4] = "5";
my2DimensionalArray[1, 0] = "6";
my2DimensionalArray[1, 1] = "7";
my2DimensionalArray[1, 2] = "8";
my2DimensionalArray[1, 3] = "9";
my2DimensionalArray[1, 4] = "10";
my2DimensionalArray[2, 0] = "11";
my2DimensionalArray[2, 1] = "12";
my2DimensionalArray[2, 2] = "12";
my2DimensionalArray[2, 3] = "14";
my2DimensionalArray[2, 4] = "15";
my2DimensionalArray[3, 0] = "16";
my2DimensionalArray[3, 1] = "17";
my2DimensionalArray[3, 2] = "18";
my2DimensionalArray[3, 3] = "19";
my2DimensionalArray[3, 4] = "20";
my2DimensionalArray[4, 0] = "21";
my2DimensionalArray[4, 1] = "22";
my2DimensionalArray[4, 2] = "23";
my2DimensionalArray[4, 3] = "24";
my2DimensionalArray[4, 4] = "25";

/*
Udskriv indeks 2,2 og 4,4  
 */

Console.WriteLine($"Index 2,2 = {my2DimensionalArray[2,2]} \nIndex 4,4 = {my2DimensionalArray[4,4]}");

