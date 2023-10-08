using ExceptionsLibrary;

// instans af DemoCode fra ExceptionsLibrary project
DemoCode demo = new DemoCode();


// Her kaldes demo.GrandPartenMethod med 10
// HUSK array er declaret med 4 pladser - Exception kommer
int result = demo.GrandParentMethod(10);

Console.WriteLine($"The value at the given position is: {result}");


