using App.Properties;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        private Form2 _form2;
        private Form3 _form3;
        public string title;
        public string description;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Номер", "Номер");
            dataGridView1.Columns.Add("Название", "Название");
            dataGridView1.Columns.Add("Описание", "Описание");
            dataGridView1.ReadOnly = true;
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
            title = _form2._title;
            description = _form2._description;
            var index = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None);
            dataGridView1.Rows.Add(new object[] { index + 2, title, description });
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
            string filePath = @"C:\Users\user\AppData\Local\todo-list.txt";
            File.Create(filePath).Close();
            
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        streamWriter.Write(cell.Value + " ");
                    }
                    streamWriter.Write(Environment.NewLine);
                }
                streamWriter.Close();
            }
            dataGridView1.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }
    }
}