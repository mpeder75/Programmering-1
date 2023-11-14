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

    }
}