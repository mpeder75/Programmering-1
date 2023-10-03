

//todo 1.  En instans oprettes vha new keyword
// En instans er et objekt der er lavet udfra en class
using System.Runtime.CompilerServices;

Car myCar = new Car();

//todo 2. Nu sættes variablerne for det nye myCar objekt
myCar.Make = "Audi";
myCar.Model = "A6";
myCar.Year = 1990;
myCar.Color = "Dark blue";

//todo 3. Printe værdier fra myCar objekt
Console.WriteLine($"My car is a {myCar.Make} { myCar.Model} year: {myCar.Year} color: { myCar.Color}");


//todo 4. determinMarketValue method bruges sammen med myCar instans
double marketValue = myCar.DeterminMarketValue();
Console.WriteLine($"Market value of my {myCar.Make} {myCar.Model} is: ${myCar.DeterminMarketValue()}");





//todo Class = et "blueprint"/skabelon der gør det lettere at lave en instans
//todo en calss "kan" bestå af både fields og methods 
class Car
{
    // Fields ( tastatur genvej: prop + tab ) 
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    // Method determinMarketValue
    public double DeterminMarketValue()
    {
        double carValue = 100.0;

        if(this.Year > 1999)        // .this refere til class Car's field Year
        {
            carValue = 10000;
        } else
        {
            carValue = 2000;
        }

        return carValue;
    }
}