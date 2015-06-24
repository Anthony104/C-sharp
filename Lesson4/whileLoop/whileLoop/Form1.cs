using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whileLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
               int i = 0;
            while (i < int.Parse(TextBox2.Text))
            {
                i++;
            }
            MessageBox.Show("The final value was: " + i.ToString());
            }

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            
    }
}

