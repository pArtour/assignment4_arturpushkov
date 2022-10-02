namespace assignment4_arturpushkov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, fact = 1, number;
            number = (int)numericUpDown1.Value;
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            textBox1.Text = fact.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}