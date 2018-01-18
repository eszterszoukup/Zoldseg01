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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); 
        }
          
        public string loginnev = "a";   
        public string jelszo = "a";  

      
     public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        } 

        private void Form2_load(object sender, EventArgs e)
        {
            //Form1.button1_Click();

             SqlConnection conn = new SqlConnection("Data Source=ESZTER-LATOP\\SQLEXPRESS12;Initial Catalog=ZOLDSEG;Integrated Security=True");

             DataTable data = new DataTable();
             SqlDataAdapter adapter = new SqlDataAdapter("exec login_ellenorzes " + loginnev + ", " + jelszo, conn);

             adapter.Fill(data);
             dataGridView1.DataSource = data;
        }
    }
}
