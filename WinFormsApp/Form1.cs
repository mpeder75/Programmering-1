using Session_15___Models; // for at kunne oprette et Vare objekt skal Models bruges 
using Session_15___BusinessLogic; // for at kunne kalde metoder fra BusinessLogic skal der bruges using

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        VareBL bl;

        public Form1()
        {
            InitializeComponent();
            bl = new VareBL();

            // DatagridView GetAllItems
            GetAllItems.DataSource = bl.GetAllItems();

            // Label GetOneItem
            Vare vare = bl.GetOneItem(2);
            GetOneItem.Text = $"ID: {vare.ID}\nItem Name: {vare.ItemName}\nItem Description: {vare.ItemDescription}\nAmount In Stock: {vare.AmountInStock}\nCost Price: {vare.CostPrice}\nProfit: {vare.Profit}";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetOneItem_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetAllItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}