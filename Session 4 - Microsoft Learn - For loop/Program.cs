//todo For loop bruges til at iterere igennem collections


// Loop fra 1 til 10
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Im printing {i.ToString()} out of 10");
}


// Print kun 7 ud af 10
for(int i = 0; i < 10; i++)
{
    if(i == 7)
    {
        Console.WriteLine($"Im only printing : {i.ToString()}");
        break;
    }
}