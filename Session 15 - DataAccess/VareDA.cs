using Session_15___Models;
using System.Configuration;
using System.Data.SqlClient;

namespace Session_15___DataAccess
{
    public class VareDA
    {
        string connString;

        public VareDA()
        {
            connString = ConfigurationManager.ConnectionStrings["home"].ToString();
        }


        public List<Vare> GetAllItems()
        {
            List<Vare> vareList = new List<Vare>();
            try
            {
                string command = "SELECT * FROM [itemDB]";
                using SqlConnection dbConn = new SqlConnection(connString);
                SqlCommand sqlCommand = new SqlCommand(command, dbConn);
                dbConn.Open();
                using SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Vare vare = new Vare();
                    vare.ID = (int)reader["ID"];
                    vare.ItemName = (string)reader[name: "ItemName"];
                    vare.ItemDescription = (string)reader["ItemDescription"];
                    vare.AmountInStock = (int)reader["AmountInStock"];
                    vare.CostPrice = (int)reader["CostPrice"];
                    vare.Profit = (int)reader["Profit"];
                    vareList.Add(vare);
                }
                dbConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error in GetAllItems: {e.Message}");
            }
            return vareList;
        }


        public Vare GetOneItem(int id)
        {
            Vare vare = new Vare();
            try
            {
                string command = "SELECT * FROM [itemDb] WHERE [id] = @ID";
                using SqlConnection dbConn = new SqlConnection(connString);
                SqlCommand sqlCommand = new SqlCommand(command, dbConn);
                sqlCommand.Parameters.AddWithValue("@ID", id);
                dbConn.Open();
                using SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    vare.ID = (int)reader["ID"];
                    vare.ItemName = (string)reader["ItemName"];
                    vare.ItemDescription = (string)reader["ItemDescription"];
                    vare.AmountInStock = (int)reader["AmountInStock"];
                    vare.CostPrice = (int)reader["CostPrice"];
                    vare.Profit = (int)reader["Profit"];
                }
                dbConn.Close();
            } catch (Exception e)
            {
                Console.WriteLine($"Error in GetOneItem: {e.Message}");
            }
            return vare;
        }
    }
}