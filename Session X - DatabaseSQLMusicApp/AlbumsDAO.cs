using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_X___DatabaseSQLMusicApp
{
    internal class AlbumsDAO
    {

        string connectionString = "datasource=localhost; port=3306; username=root;password=root; database=music";



        // CRUD - GetAll
        public List<Album> getAllAlbums()
        {
            // oprete liste der skal udfyldes og returneres til siodst
           List<Album> allAlbumsList = new List<Album>();

            //! Installer nuget MySQL.Data - Kræves for at kunne gforbinde til mySql database

            // opret forbindelse til database
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // oprette og sende SQL query til database -> husk at sende connection string med
            MySqlCommand command = new MySqlCommand("SELECT * FROM albums", connection);


            // using kan se som et while loop, der læser fra database, og gemmer i allAlbumsList
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album 
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)                      
                    };
                    allAlbumsList.Add(a);
                }
            }
            connection.Close();
            return allAlbumsList;      
        }



        // CRUD - GetOne
        public List<Album> getOneAlbum(string searchTerm)
        {
            List<Album> allAlbumsList = new List<Album>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM albums WHERE ALBUM_TITLE LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    allAlbumsList.Add(a);
                }
            }
            connection.Close();
            return allAlbumsList;
        }
    }


}

