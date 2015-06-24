using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace two_nested_for_loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] myArray = { "Anthony", "AC", "Tony", "AC104" };

            for (int i = 0; i < myArray.Length; )
            {
                foreach (var nickname in myArray)
                {
                    MessageBox.Show(i++ + " " + nickname);
                }

            }

        }
    }}




