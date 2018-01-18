using System;
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

        public string loginnev = "";
        public string jelszo = "";

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loginnev =  textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            jelszo = textBox2.Text ;
        }

        protected void form1_load(object sender, EventArgs e)
        {

            // dataGridView1.DataSource = data; ki kellene iratni a Form2-n, de a két form nem "látja" egymást


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=ESZTER-LATOP\\SQLEXPRESS12;Initial Catalog=ZOLDSEG;Integrated Security=True");

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("exec login_ellenorzes " + loginnev + ", " + jelszo, conn);

            adapter.Fill(data);
            
            
              
            this.Hide();
            Form f2 = new Form2();

           

            f2.Show();
        }
    }
}
       
    
                                                           
         




    

