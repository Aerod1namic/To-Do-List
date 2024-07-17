using System;
using System.Windows.Forms;

namespace App
{
    public partial class Form3 : Form
    {
        public string number;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = textBox1.Text;
            Close();
        }
    }
}