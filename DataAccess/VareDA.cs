using Models;

namespace DataAccess
{
    public class VareDA
    {

        List<Vare> vareList;

        public VareDA()
        {
            vareList = new List<Vare>();
            HardcodedVare();
        }


        public List<Vare> GetAll() 
        {
            return vareList;
        }

        public Vare GetOne(int id)
        {
            foreach (var item in vareList)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return new Vare();
        }

        public bool Create (Vare vare)
        {
            foreach(var item in vareList)
            {
                if (item.Id == vare.Id)
                {
                    vareList.Add(item);
                    return true;
                }
            }
            return false;
        }


        public bool Delete(int id)
        {
            foreach (var item in vareList)
            {
                if (item.Id == id)
                {
                    vareList.Remove(item);
                    return true;
                }
            }
            return false;
        }









        void HardcodedVare()
        {
            vareList.Add(new Vare { Id = 1, Name = "Banan", Description = "Frugt", CostPrice = 5, Profit = 2});
            vareList.Add(new Vare { Id = 2, Name = "Æble", Description = "Frugt", CostPrice = 5, Profit = 2});
            vareList.Add(new Vare { Id = 3, Name = "Ananas", Description = "Frugt", CostPrice = 5, Profit = 2});
            vareList.Add(new Vare { Id = 4, Name = "Pære", Description = "Frugt", CostPrice = 5, Profit = 2});
            vareList.Add(new Vare { Id = 5, Name = "Hindbær", Description = "Frugt", CostPrice = 5, Profit = 2});
        }

    }
}