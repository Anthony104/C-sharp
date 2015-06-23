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
            if (comboBox1.Text != "Anthony")
            {
                if (comboBox1.Text == "Tony")
                {
                  MessageBox.Show("you picked Tony");
                }
            else 
            {
                MessageBox.Show("im not sure who you picked.");
            }
        }
            else
             {
                MessageBox.Show("Anthony");
             }
        }

    

