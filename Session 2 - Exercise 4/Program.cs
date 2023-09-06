

/*
Læg tallene på indeks 1,3,5,8 sammen 
 */

int[] myIntArray = new int[10];

myIntArray[0] = 1;
myIntArray[1] = 2;
myIntArray[2] = 3;
myIntArray[3] = 4;
myIntArray[4] = 5;
myIntArray[5] = 6;
myIntArray[6] = 7;
myIntArray[7] = 8;
myIntArray[8] = 9;
myIntArray[9] = 10;

int sum = myIntArray[2] + myIntArray[7];

Console.WriteLine($"Index 7({myIntArray[2]}) + index 7({myIntArray[7]}) lagt sammen er = {sum}");
