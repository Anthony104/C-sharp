﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
    
        
        


        private void button1_Click(object sender, EventArgs e)
        {
           switch (listBox1.SelectedItem.ToString())
        {    
             case "Foobar":
             MessageBox.Show("You picked Foobar"); 
             break;
           
             case "Bazquirk": 
             MessageBox.Show("You picked Bazquirk");
             break;
            
             default: 
             MessageBox.Show("You picked something else.");
             break;
         }
        
        }

       

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}