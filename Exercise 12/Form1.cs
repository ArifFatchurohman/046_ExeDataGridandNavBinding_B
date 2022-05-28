using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Arif" && textBox2.Text == "mudamendunia")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username maupun Password salah!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
