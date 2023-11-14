using Session_15___BusinessLogic;
using Session_15___Models;

VareBL bl = new VareBL();

Vare banan = new Vare 
{ 
    ID = 10, 
    ItemName = "Banana", 
    ItemDescription = "Fruit",
    AmountInStock = 10, 
    CostPrice = 2, 
    Profit = 3
};

Console.WriteLine($"Object:{banan.ItemName} istanciated\nId:{banan.ID}\nDescription:{banan.ItemDescription}\nStock:{banan.AmountInStock}\nCost price:{banan.CostPrice}\nProfit:{banan.Profit}\nCalculated Salesprice:{banan.SalePrice}\n");


Console.WriteLine("------- Print from GetAllItems() -------");
List<Vare> getAllItems = bl.GetAllItems();
foreach (Vare vare in getAllItems)
{
    Console.WriteLine($"ID: {vare.ID}");
    Console.WriteLine($"Item Name: {vare.ItemName}");
    Console.WriteLine($"Item Description: {vare.ItemDescription}");
    Console.WriteLine($"Amount In Stock: {vare.AmountInStock}");
    Console.WriteLine($"Cost Price: {vare.CostPrice}");
    Console.WriteLine($"Profit: {vare.Profit}\n");
   
}

Console.WriteLine("------- Print from GetOneItem() -------");
Vare getOneItem = bl.GetOneItem(2);

foreach (var prop in getOneItem.GetType().GetProperties())
{
    Console.WriteLine($"{prop.Name}: {prop.GetValue(getOneItem)}");
}



