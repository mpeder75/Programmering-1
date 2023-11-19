using Session_16___BusinessLogic;
using Session_16___Models;

// Test om Vare class istanciere nyt objekt vha ToString() i Vare
Vare torsk = new Vare 
{ 
    ID = 10,
    ItemName = "Torsk",
    ItemDescription = "Fisk",
    StockAmount = 150,
    BuyingPrice = 10,
    Profit = 40
};

Console.WriteLine("Print fra ToString:\n" + torsk.ToString());




// CRUD Create: instans a VareBL for at tjekke om Create kalder fra BL til DA
VareBL bl = new VareBL();

Vare kokus = new Vare 
{
    ID = 11, 
    ItemName = "Kokus",
    ItemDescription = "Nød",
    BuyingPrice = 13,
    Profit = 12,
    StockAmount = 5
};
Console.WriteLine($"\n{kokus.ToString()}");

bool isKokusCreated = bl.Create(kokus);
Console.WriteLine("\nKokus object is created: " + isKokusCreated);


// CRUD Update: Her bruges kokus tail at teste - vi vil ændre ItemName
kokus.ItemName = "Børge";
Console.Write("\nKokus is changed to: " + kokus.ItemName);


// CRUD Delete: opretter en objekt gennem Create() og sletter det med Delete()
bl.Create(new Vare { ID = 20, ItemName = "figen", ItemDescription = "frugt", BuyingPrice = 5, Profit = 1, StockAmount = 1 });
Console.WriteLine($"\n\nFign created \n{bl.GetOneItem(20).ToString()}");

bool isDeleted = bl.Delete(20);
Console.WriteLine($"\nIs fign object deleted?: {isDeleted}");

List<Vare> updatedVareList = new List<Vare>(bl.GetAllItems());
foreach (var item in updatedVareList)
{
    if (item.ItemName == "fign")
    {
        Console.WriteLine("The object is NOT deleted");
        return;
    }
    Console.WriteLine("Object is allready deleted");
}
