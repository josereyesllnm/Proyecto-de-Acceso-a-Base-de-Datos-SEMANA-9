using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Formulario_MDI
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {

            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fusuarios form = new fusuarios();
            form.ShowDialog();
        }

        private void btnentrarusuario_sqlserver_Click(object sender, EventArgs e)
        {

        }

      
        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btnentrarusuario_access_Click(object sender, EventArgs e)
        {
            try
            {
                //Creado la variable para la nueva conexion
                OleDbConnection conexion_access = new OleDbConnection();
               
                //Cadena de conexión para la base de datos
                conexion_access.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Sistema\sistema.mdb;Persist Security Info=False;";
                
                //Abriendo conexion
                conexion_access.Open();
                
                //Consulta a tabla de usuarios en la base de datos
                
                //Para encontrar fila que tiene los datos del usuario y clave ingresados
                
                OleDbDataAdapter consulta = new OleDbDataAdapter("SELECT * FROM tusuarios", conexion_access);
                
                //OleDbDataReader reader = command.ExecuteReader();
              
                DataSet resultado = new DataSet();
                consulta.Fill(resultado);
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    if ((txtusuario.Text == registro["nombre"].ToString()) && (txtclave.Text ==
                    registro["clave"].ToString()))
                    {
                        //llamando formulario principal llamado menu
                        fusuarios fm = new fusuarios();
                        fm.Show(); //abrir menu
                        this.Hide();//ocultar el formulario de login
                    }
                }
                conexion_access.Close();

            } //Cierre de Try
              //Si la conexión falla muestra mensaje de error
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                //en caso que usuario y clave sean incorrectos mostrar mensaje de error
                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtusuario.Focus();
            }
           
        }

        private void bentrar_sqlserver_Click(object sender, EventArgs e)
        {

        }
    }
}
