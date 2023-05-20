using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.quantity + ", спасибо большое за прохождение теста!";
            label3.Text += Convert.ToString(Form2.correct_answers) + "/20";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
