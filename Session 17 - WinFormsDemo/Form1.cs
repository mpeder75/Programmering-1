namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "First name";    // ændre label fra 'label1' til 'First name'
            label2.Text = "Last name";
            label3.Text = "Full name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Når man indtaster navn i textbox1 og 2 og trykkrt på knap, kommer message m 'Hello' indtastet navn
            //MessageBox.Show($"Hello {textBox1.Text} {textBox2.Text}");

            // Når der er indtastet i textbox1 + 2, vise disse i textbox3
            textBox3.Text = $"{textBox1.Text} {textBox2.Text}";

            // når man trykker på button, vil progressbar blive 10% mere udfyldty
            //progressBar1.Value += 10;


            // når knap trykkes vil FORM2 åbne
            // Form2 frm = new Form2();
            // frm.Show();
            // this.Hide();

            // Når man trykkler på knap, vil progressbar i bund få 5% grøn, og teksten ved siden af skifter til 'working...'
            toolStripProgressBar1.Value += 5;
            toolStripStatusLabel1.Text = "Working...";

        }

        // Når man trykker på about i top menu, vil messagebox printe
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Created by: Michael");
        }

        // Når man trykker på File->Exit, vil program lukke 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
