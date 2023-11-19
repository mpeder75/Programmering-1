using Session_16___DataAccess;
using Session_16___Models;

namespace Session_16___BusinessLogic
{
    public class VareBL
    {
        VareDA db = new VareDA();



        public List<Vare> GetAllItems()
        {
            return db.GetAllItems();
        }

        public Vare GetOneItem(int id)
        {
            return db.GetOneItem(id);
        }

        public bool Create(Vare vare)
        {
            if (Validate(vare))
            {
                return db.Create(vare);
            }
            return false;

        }

        public bool Update(Vare vare)
        {
            return db.Update(vare);
        }

        public bool Delete(int id)
        {
            return db.Delete(id);
        }






        public bool Validate(Vare vare)
        {
            bool isValid = false;

            if (vare is Vare && vare.ID > 0 && vare.SalesPrice > 0)
            {
                isValid = true;
                return isValid;
            }
            return isValid;
        }


    }
}