using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Anthony")
            {
                MessageBox.Show("you picked Anthony");
            }
            else if (comboBox1.Text == "Tony")
            {
                MessageBox.Show("you picked Tony");
            }

            else if (comboBox1.Text == "Anto")
            {
                MessageBox.Show("you picked Anto");
            }

            else
            {
                MessageBox.Show("ERROR!!!!");
            }
        }
    }
}
