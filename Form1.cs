using App.Properties;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        private Form2 _form2;
        private Form3 _form3;
        public string _title;
        public string _description;
        public DataGridView DataGridView;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Номер", "Номер");
            dataGridView1.Columns.Add("Название", "Название");
            dataGridView1.Columns.Add("Описание", "Описание");
            dataGridView1.CancelEdit();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            Text = "To-do list";
           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form2 = new Form2();
            _form2.ShowDialog();
            _title = _form2._title;
            _description = _form2._description;
            var index = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None);
            dataGridView1.Rows.Add(new object[] { index + 2, _title, _description });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _form3 = new Form3();
            _form3.ShowDialog();
            var goalNumber = int.Parse(_form3.number);
            dataGridView1.Rows.RemoveAt(goalNumber - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}