

// 1. man istanciere myCar udfra Car class
// NÅR Car() bruges kaldes constructor, her uden at sætte værdier
Car myCar = new Car();


// 2. Nu bruges den overloaded constructor med argument
Car myNewCar = new Car("Audi", "A6", 2020, "Dark Blue");

// 3. myNewCar printes
Console.WriteLine($"{myNewCar.Make} {myNewCar.Model} {myNewCar.Year} {myNewCar.Color}");




class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public double OriginalPrice { get; set; }


    //todo Constructor - Her hardcodes fields igennem constructor
    public Car()
    {
        this.Make = "Nissan";
    }

    //todo Overload constructor
    public Car(string make, string model, int year, string color)
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
    }
}