namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static string quantity;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                
                quantity = textBox1.Text + " " + textBox2.Text;
                Hide();
                Form2 f2 = new Form2();
                f2.Show();

            }
            else
            {
                MessageBox.Show("¬ведите все данные!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}