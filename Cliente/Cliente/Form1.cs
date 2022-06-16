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

namespace Cliente
{
    public partial class frmMostrarDatos : Form
    {
        public frmMostrarDatos()
        {
            InitializeComponent();
        }

        private void frmMostrarDatos_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=192.168.1.76,1433;Database=Persona;User Id=sa;Password=Contr@12345");
            SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT * FROM Persona;", connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Persona");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Persona";
        }
    }
}
