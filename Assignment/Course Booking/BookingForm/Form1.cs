using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "B";
                checkBox1.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                checkBox1.Text = "1";
                checkBox1.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Text = "B";
                checkBox2.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                checkBox2.Text = "2";
                checkBox2.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Text = "B";
                checkBox3.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                checkBox3.Text = "3";
                checkBox3.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.Text = "B";
                checkBox4.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                checkBox4.Text = "4";
                checkBox4.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.Text = "B";
                checkBox5.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                checkBox5.Text = "5";
                checkBox5.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox6.Text = "B";
                checkBox6.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                checkBox6.Text = "6";
                checkBox6.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox7.Text = "B";
                checkBox7.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                checkBox7.Text = "7";
                checkBox7.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox8.Text = "B";
                checkBox8.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                checkBox8.Text = "8";
                checkBox8.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox9.Text = "B";
                checkBox9.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                checkBox9.Text = "9";
                checkBox9.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                checkBox10.Text = "B";
                checkBox10.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                checkBox10.Text = "10";
                checkBox10.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox11.Text = "B";
                checkBox11.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                checkBox11.Text = "11";
                checkBox11.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox12.Text = "B";
                checkBox12.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                checkBox12.Text = "12";
                checkBox12.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

