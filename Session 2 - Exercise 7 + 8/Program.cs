
/* Opgave 7: Opret et array med 2 dimensioner der indeholder 7 heltal på x og y */

int[,] my2DimArray = new int[7, 7];

my2DimArray[0, 0] = 1;
my2DimArray[0, 1] = 2;
my2DimArray[0, 2] = 3;
my2DimArray[0, 3] = 4;
my2DimArray[0, 4] = 5;
my2DimArray[0, 5] = 6;
my2DimArray[0, 6] = 7;

my2DimArray[1, 0] = 8;
my2DimArray[1, 1] = 9;
my2DimArray[1, 2] = 10;
my2DimArray[1, 3] = 11;
my2DimArray[1, 4] = 12;
my2DimArray[1, 5] = 13;
my2DimArray[1, 6] = 14;

my2DimArray[2, 0] = 15;
my2DimArray[2, 1] = 16;
my2DimArray[2, 2] = 17;
my2DimArray[2, 3] = 18;
my2DimArray[2, 4] = 19;
my2DimArray[2, 5] = 20;
my2DimArray[2, 6] = 21;

my2DimArray[3, 0] = 22;
my2DimArray[3, 1] = 23;
my2DimArray[3, 2] = 24;
my2DimArray[3, 3] = 25;
my2DimArray[3, 4] = 26;
my2DimArray[3, 5] = 27;
my2DimArray[3, 6] = 28;

my2DimArray[4, 0] = 29;
my2DimArray[4, 1] = 30;
my2DimArray[4, 2] = 31;
my2DimArray[4, 3] = 32;
my2DimArray[4, 4] = 33;
my2DimArray[4, 5] = 34;
my2DimArray[4, 6] = 35;

my2DimArray[5, 0] = 36;
my2DimArray[5, 1] = 37;
my2DimArray[5, 2] = 38;
my2DimArray[5, 3] = 39;
my2DimArray[5, 4] = 40;
my2DimArray[5, 5] = 41;
my2DimArray[5, 6] = 42;

my2DimArray[6, 0] = 43;
my2DimArray[6, 1] = 44;
my2DimArray[6, 2] = 45;
my2DimArray[6, 3] = 46;
my2DimArray[6 ,4] = 47;
my2DimArray[6, 5] = 48;
my2DimArray[6, 6] = 49;

// ------------------------------------------------------------------------- //

/* Opgave 8: Summer alle tal på hver y-akse og udskriv. Summer alle de tal der indgår i krydset på arrayet */

int sumY1 = my2DimArray[0, 0] + my2DimArray[0, 1] + my2DimArray[0, 2] + my2DimArray[0, 3] + my2DimArray[0, 4] + my2DimArray[0, 5] + my2DimArray[0, 6]; 
int sumY2 = my2DimArray[1, 0] + my2DimArray[1, 1] + my2DimArray[1, 2] + my2DimArray[1, 3] + my2DimArray[1, 4] + my2DimArray[1, 5] + my2DimArray[1, 6]; 
int sumY3 = my2DimArray[2, 0] + my2DimArray[2, 1] + my2DimArray[2, 2] + my2DimArray[2, 3] + my2DimArray[2, 4] + my2DimArray[2, 5] + my2DimArray[2, 6]; 
int sumY4 = my2DimArray[3, 0] + my2DimArray[3, 1] + my2DimArray[3, 2] + my2DimArray[3, 3] + my2DimArray[3, 4] + my2DimArray[3, 5] + my2DimArray[3, 6]; 
int sumY5 = my2DimArray[4, 0] + my2DimArray[4, 1] + my2DimArray[4, 2] + my2DimArray[4, 3] + my2DimArray[4, 4] + my2DimArray[4, 5] + my2DimArray[4, 6]; 
int sumY6 = my2DimArray[5, 0] + my2DimArray[5, 1] + my2DimArray[5, 2] + my2DimArray[5, 3] + my2DimArray[5, 4] + my2DimArray[5, 5] + my2DimArray[5, 6]; 
int sumY7 = my2DimArray[6, 0] + my2DimArray[6, 1] + my2DimArray[6, 2] + my2DimArray[6, 3] + my2DimArray[6, 4] + my2DimArray[6, 5] + my2DimArray[6, 6];

Console.WriteLine($"Total sum er {sumY1 + sumY2 + sumY3 + sumY4 + sumY5 + sumY6 + sumY7}");