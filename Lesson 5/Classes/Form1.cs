﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicle myCar = new vehicle();
            myCar.Make = "DeLorean";
            myCar.Model = "Time Machine";
            myCar.ElapsedMilage = 9999999;

            MessageBox.Show(myCar.Make + Environment.NewLine + myCar.Model + Environment.NewLine + myCar.ElapsedMilage.ToString());
            
            
        }
    }
}
