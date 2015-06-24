using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forLoopWithSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                switch (listBox1.SelectedItems[i].ToString())
                {
                    case "Foobar":
                        MessageBox.Show("Foobar");
                        break;

                    case "Bazquirk":
                        MessageBox.Show("Bazquirk");
                        break;

                    case "Widgets":
                        MessageBox.Show("Widgets");
                        break;

                    case "Gadgets":
                        MessageBox.Show("Gadgets");
                        break;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
