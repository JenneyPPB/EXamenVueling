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
   

namespace conectando_con_la_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
                SqlConnection conec = new SqlConnection("Data Source=.;Initial Catalog=Mi SegundaDB;Integrated Security=True");
                conec.Open();
         
        }
    }      
        
}
