using Session_16___Models;
using System.Configuration;
using System.Data.SqlClient;

namespace Session_16___DataAccess
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
            List<Vare> GetAllItems = new List<Vare>();
            string command = "SELECT * FROM itemDB";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            dbConn.Open();
            using SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Vare vare = new Vare();
                vare.ID = (int)reader["ID"];
                vare.ItemName = (string)reader["Item name"];
                vare.ItemDescription = (string)reader["Item Description"];
                vare.BuyingPrice = (int)reader["Buyying price"];
                vare.Profit = (int)reader["Profit"];
                vare.StockAmount = (int)reader["Stock Amount"];
                GetAllItems.Add(vare);  
            }
            dbConn.Close();
            return GetAllItems;
        }

        public Vare GetOneItem(int id)
        {
            Vare vare = new Vare();
            string command = "SELECT * FROM itemDB WHERE id = @ID";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            dbConn.Open(); // Database åbnes INDEN query executes
            using SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                vare.ID = (int)reader["ID"];
                vare.ItemName = (string)reader["Item name"];
                vare.ItemDescription = (string)reader["Item Description"];
                vare.BuyingPrice = (int)reader["Buying price"];
                vare.Profit = (int)reader["Profit"];
                vare.StockAmount = (int)reader["Stock Amount"];
            }
            dbConn.Close();
            return vare;
        }


        public bool Create(Vare vare)
        {
            using SqlConnection dbConn = new SqlConnection(connString);
                        using SqlCommand sqlCommand =
                new SqlCommand(
                    "INSERT Vare (Id,Itemname,Itemdescription,Buyingprice,Profit,Stockamount)" +
                    " values(@Id,@Itemdescription,@Buyingprice,@Profit,@Stockamount)");
            sqlCommand.Parameters.AddWithValue("@Id", vare.ID);
            sqlCommand.Parameters.AddWithValue("@Itemname", vare.ItemName);
            sqlCommand.Parameters.AddWithValue("@Itemdescription", vare.ItemDescription);
            sqlCommand.Parameters.AddWithValue("@Buyingprice", vare.BuyingPrice);
            sqlCommand.Parameters.AddWithValue("@Profit", vare.Profit);
            sqlCommand.Parameters.AddWithValue("@Stockamount", vare.StockAmount);
            dbConn.Open(); // Database åbnes INDEN query executes
            int res = sqlCommand.ExecuteNonQuery();
            dbConn.Close();
            if (res == 0) return false; return true;
        }


        public bool Update(Vare vare) 
        {
            using SqlConnection dbConn = new SqlConnection(connString);
            string command = "UPDATE Vare SET Itemname = @Itemname, Itemdescription = @Itemdescription, Buyingprice = @Buyingprice, Profit = @Profit, Stockamount = @Stockamount WHERE Id = @Id";
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@Id", vare.ID);
            sqlCommand.Parameters.AddWithValue("@Itemname", vare.ItemName);
            sqlCommand.Parameters.AddWithValue("@Itemdescription", vare.ItemDescription);
            sqlCommand.Parameters.AddWithValue("@Buyingprice", vare.BuyingPrice);
            sqlCommand.Parameters.AddWithValue("@Profit", vare.Profit);
            sqlCommand.Parameters.AddWithValue("@Stockamount", vare.StockAmount);
            dbConn.Open(); // Database åbnes INDEN query executes
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected > 0;
        }

        public bool Delete(int id)
        {
            string command = "DELETE FROM itemDB WHERE id = @ID";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            dbConn.Open(); // Database åbnes INDEN query executes
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected > 0;
        }

    }
}