using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
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
            List<Album> getAllAlbums = new List<Album>();

            //! Installer nuget MySQL.Data - Kræves for at kunne gforbinde til mySql database

            // opret forbindelse til database
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // oprette og sende SQL query til database -> husk at sende connection string med
            MySqlCommand command = new MySqlCommand("SELECT * FROM albums", connection);


            // using kan se som et while loop, der læser fra database, og gemmer i getAllAlbums
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
                    // album a opsættes så den får Tracks fra getTracksForAlbum metoden
                    a.Tracks = getTracksForAlbum(a.ID);

                    getAllAlbums.Add(a);
                }
            }
            connection.Close();
            return getAllAlbums;
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

        // CRUD - Create
        public int CreateAlbum(Album album)
        {
            // opret forbindelse til database
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // oprette og sende SQL query til database -> husk at sende connection string med
            MySqlCommand command = new MySqlCommand
            ("INSERT INTO albums (ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION) VALUES (@albumtitle, @artist, @year, @imageURL, @description)", connection);

            command.Parameters.AddWithValue("@albumtitle", album.AlbumName);
            command.Parameters.AddWithValue("@artist", album.ArtistName);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);

            int newRows = command.ExecuteNonQuery();
            connection.Close();

            return newRows;
        }
    
        
        // CRUD - Denne henter alle tracks, udfra det albumID der passes
        public List<Track> getTracksForAlbum (int albumId)
        {
            List<Track> returnThese = new List<Track>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM TRACKS WHERE albums_ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumId);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track tracksToAdd = new Track
                    {
                       ID = reader.GetInt32(0),
                       Name = reader.GetString(1),
                       Number = reader.GetInt32(2),
                       VideoURL = reader.GetString(3),
                       Lyrics = reader.GetString(4)
                    };
                    returnThese.Add(tracksToAdd);
                }
            }
            connection.Close();
            return returnThese;
        }


        public List<JObject> getTracksUsingJoin(int albumId)
        {
            List<JObject> returnThese = new List<JObject>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT tracks.ID AS TrackID, albums.ALBUM_TITLE ,track_title, video_url FROM tracks JOIN albums ON albums_ID = albums.ID WHERE albums_ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumId);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    JObject newTrack = new JObject();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        newTrack.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }
                    returnThese.Add(newTrack);
                }
            }
            connection.Close();
            return returnThese;
        }



    }
}




