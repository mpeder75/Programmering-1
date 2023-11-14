using Session_15___Models;
using Session_15___DataAccess;

namespace Session_15___BusinessLogic
{
    public class VareBL
    {
        VareDA db;

        public VareBL()
        {
            db = new VareDA();
        }

        public List<Vare> GetAllItems()
        {
            try
            {
                return db.GetAllItems();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred in GetAllItems: {ex.Message}");
                return new List<Vare>();
                // eller return null
            }
        }

        public Vare GetOneItem(int id) 
        {
            try
        {
                return db.GetOneItem(id);
            }
        catch (Exception ex)
        {
                Console.WriteLine($"Error occurred in GetOneItem: {ex.Message}");
                
                return new Vare();
                // eller return null
            }
        }
    }
}