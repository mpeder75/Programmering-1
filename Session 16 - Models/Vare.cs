namespace Session_16___Models
{
    public class Vare
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int StockAmount { get; set; }
        public int BuyingPrice { get; set; }
        public int Profit { get; set; }
        public int SalesPrice 
        { 
            get { return BuyingPrice * Profit; }
        }



        // override ToString(), der kan kaldes fra program.cs
        public override string ToString()
        {
            return $"Id: {ID}\nItem name: {ItemName}\nItem description: {ItemDescription}\nAmount in stock: {StockAmount}\nBuying Price: {BuyingPrice}\nProfit: {Profit}\nSales Price: {SalesPrice}";
        }

    }
}