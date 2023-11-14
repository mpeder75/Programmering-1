namespace Session_15___Models
{
    public class Vare
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int AmountInStock { get; set; }
        public int CostPrice { get; set; }
        public int Profit { get; set; }
        
        public int SalePrice
        {
            get { return CostPrice + Profit; }
        }
     }
}