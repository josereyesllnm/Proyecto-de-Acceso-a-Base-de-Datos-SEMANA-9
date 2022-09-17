using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }



        SqlConnection coneccion = new SqlConnection("server=JOSEREYES ; database = LOGIN ; INTEGRATED SECURITY = true");


        
        


        private void btnlogin_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            SqlCommand comando = new SqlCommand("SELECT USUARIO, CONTRASEÑA FROM PERSONA WHERE USUARIO = @vusuario AND CONTRASEÑA = @vcontraseña", coneccion);
            comando.Parameters.AddWithValue("@vusuario",txtusuario.Text);
            comando.Parameters.AddWithValue("@vcontraseña", txtcontraseña.Text);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                coneccion.Close();
                MENU pantalla = new MENU();
                pantalla.Show();

            }
          

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
