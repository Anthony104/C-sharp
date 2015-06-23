using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] myArray = new string[4];
            myArray[0] = "Liverpool"; 
            myArray[1] = "Chelsea";
            myArray[2] = "Man City";
            myArray[3] = "Arsenal";

            MessageBox.Show(myArray[0]);
        }
    }
}
