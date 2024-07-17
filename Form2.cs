using System;
using System.Windows.Forms;

namespace App
{
    public partial class Form2 : Form
    {
        public string _title;
        public string _description;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _title = textBox1.Text;
            _description = textBox2.Text;
            Close();
        }
    }
}