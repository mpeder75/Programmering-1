namespace Models
{
    public class Vare
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CostPrice { get; set; }
        public int Profit { get; set; }
        public int SalesPrice
        {
            get { return CostPrice + Profit; }            
        }


    }
}