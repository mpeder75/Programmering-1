namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "First name";    // �ndre label fra 'label1' til 'First name'
            label2.Text = "Last name";
            label3.Text = "Full name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // N�r man indtaster navn i textbox1 og 2 og trykkrt p� knap, kommer message m 'Hello' indtastet navn
            //MessageBox.Show($"Hello {textBox1.Text} {textBox2.Text}");

            // N�r der er indtastet i textbox1 + 2, vise disse i textbox3
            textBox3.Text = $"{textBox1.Text} {textBox2.Text}";

            // n�r man trykker p� button, vil progressbar blive 10% mere udfyldty
            //progressBar1.Value += 10;


            // n�r knap trykkes vil FORM2 �bne
            // Form2 frm = new Form2();
            // frm.Show();
            // this.Hide();

            // N�r man trykkler p� knap, vil progressbar i bund f� 5% gr�n, og teksten ved siden af skifter til 'working...'
            toolStripProgressBar1.Value += 5;
            toolStripStatusLabel1.Text = "Working...";

        }

        // N�r man trykker p� about i top menu, vil messagebox printe
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Created by: Michael");
        }

        // N�r man trykker p� File->Exit, vil program lukke 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
