﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        //public string conString = "Data Source=ESZTER-LATOP\\SQLEXPRESS12;Initial Catalog=ZOLDSEG;Integrated Security=True";

        public string loginnev = "eszter";
        public string jelszo = "eszter";

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = loginnev;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = jelszo;
        }

        protected void form1_load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
       
    
                                                           
         




    

