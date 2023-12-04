namespace Session_X___DatabaseSQLMusicApp
{
    public partial class Form1 : Form
    {

        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();

        public Form1()
        {
            InitializeComponent();
        }

        private void loadAlbumsButton_Click(object sender, EventArgs e)
        {
            // istancier AlbumsDAO class, så den kan bruges
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albums = albumsDAO.getAllAlbums();

            // samlaekoble database og gridview i Form1
            albumBindingSource.DataSource = albums;
            dgvLoadAlbums.DataSource = albumBindingSource;

            // det første billede der skal loades i picturebox
            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/thumb/4/42/Beatles_-_Abbey_Road.jpg/220px-Beatles_-_Abbey_Road.jpg");

        }

        private void searchAlbumsButton_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // samlaekoble database og gridview i Form1
            albumBindingSource.DataSource = albumsDAO.getOneAlbum(searchTextBox.Text);

            dgvLoadAlbums.DataSource = albumBindingSource;
        }

        //! Når der klikkes på en specifik celle i List, skal alle tracks hentes
        private void dgvLoadAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlbumsDAO albumsDAO= new AlbumsDAO();

            // opsætter at når der trykkes på en celle i listen, sættes den til datagridview 
            DataGridView dataGridView = (DataGridView)sender;

            // når man trykker på en celle gemmes celle nummer (bruges nedenfor)
            int rowClicked = dataGridView.CurrentRow.Index;

            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            pictureBox1.Load(imageURL);

            //! databinding - når der trykkes på en celle, 
            tracksBindingSource.DataSource = albums[rowClicked].Tracks;
            dgvLoadTracks.DataSource = tracksBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // når 'Add Album' button trykkes på
            Album album = new Album 
            { 
            AlbumName = txtAlbumName.Text,
            ArtistName = txtArtist.Text,
            Year = Int32.Parse(txtYear.Text),
            ImageURL = txtImageURL.Text,
            Description = txtDescription.Text
            };   
            
            AlbumsDAO albumDAO = new AlbumsDAO();
            int result = albumDAO.CreateAlbum(album);
            MessageBox.Show(result + " Album created");
            
        }
    }
}
