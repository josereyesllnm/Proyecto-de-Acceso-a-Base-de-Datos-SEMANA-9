using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace Formulario_MDI
{
    public partial class FUSUARIOS2 : Form
    {
        public string cadena_conexion = "Database=agenda;Data Source=Localhost;User Id=Maydelin;Password=Aliciaperdomo2508";
        public string usuario_eliminar;
        public string usuario_modificar;
        
        public FUSUARIOS2()
        {
            InitializeComponent();
        }

        private void BTNMENU_Click(object sender, EventArgs e)
        {
            MENU fprincipal = new MENU();
            fprincipal.Show();
        }

        private void bTNsalir_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BANTERIOR_Click(object sender, EventArgs e)
        {
           
        }

        private void BPRIMERO_Click(object sender, EventArgs e)
        {
           
        }

        private void BSIGUIENTE_Click(object sender, EventArgs e)
        {
            
        }

        private void BULTIMO_Click(object sender, EventArgs e)
        {
            
        }

        private void FUSUARIOS2_Load(object sender, EventArgs e)
        {
            //Desabilitar campos, se activan al crear nuevo registro
            txtUSUARIO.Enabled = false;
            txtCLAVE.Enabled = false;
            lstNIVEL.Enabled = false;

            try
            {
                string consulta = "select * from contactos";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";


            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void txtUSUARIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void BNUEVO_Click(object sender, EventArgs e)
        {
            txtUSUARIO.Enabled = true;
            txtCLAVE.Enabled = true;
            lstNIVEL.Enabled = true;
            txtUSUARIO.Text = "";
            txtCLAVE.Text = "";
            lstNIVEL.Text = "";
            txtUSUARIO.Focus();
            BNUEVO.Visible = false;
            BGUARDAR.Visible = true;
        }

        private void BGUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO Contactos(Nombre,Clave,Nivel) Values(?Nombre,?Clave,?Nivel)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?Nombre", MySqlDbType.VarChar, 75).Value = txtUSUARIO.Text;
                myCommand.Parameters.Add("?Clave", MySqlDbType.VarChar, 75).Value = txtCLAVE.Text;
                myCommand.Parameters.Add("?Nivel", MySqlDbType.VarChar, 75).Value = lstNIVEL.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Contacto agregado con éxito", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from contactos";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el CONTACTO", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            BNUEVO.Visible = true;
            BGUARDAR.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtUSUARIO.Enabled = false;
            txtCLAVE.Enabled = false;
            lstNIVEL.Enabled = false;
            BNUEVO.Focus();
        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            txtUSUARIO.Enabled = true;
            txtCLAVE.Enabled = true;
            lstNIVEL.Enabled = true;

            txtUSUARIO.Focus();

            BMODIFICAR.Visible = false;
            BACTUALIZAR.Visible = true;

            usuario_modificar = txtUSUARIO.Text.ToString();
        }

        private void BACTUALIZAR_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string Nom = txtUSUARIO.Text.ToString();
                string Cla = txtCLAVE.Text.ToString();
                string Niv = lstNIVEL.Text;


                string myInsertQuery = "UPDATE contactos SET Nombre = ?Nombre, Clave = ?Clave, Nivel = ?Nivel Where Nombre = " + usuario_modificar + "";


                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                //En caso de usar primera forma, se pasan estos parámetros.
                myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtUSUARIO.Text;
                myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 75).Value = txtCLAVE.Text;
                myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 11).Value = lstNIVEL.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Contacto modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from contactos";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al modificar el CONTACTO", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            BMODIFICAR.Visible = true;
            BACTUALIZAR.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtUSUARIO.Enabled = false;
            txtCLAVE.Enabled = false;
            lstNIVEL.Enabled = false;
            BMODIFICAR.Focus();

        }

        private void BBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "select * from contactos Where idusuario = " + TXTBUSCAR.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);

                myCommand.Connection = myConnection;
                myConnection.Open();

                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txtUSUARIO.Text = (myReader.GetString(1));
                    txtCLAVE.Text = (myReader.GetString(2));
                    lstNIVEL.Text = (myReader.GetString(3));
                }
                else
                {
                    MessageBox.Show("El contacto no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myReader.Close();
                myConnection.Close();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            BNUEVO.Visible = true;
            BGUARDAR.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtUSUARIO.Enabled = false;
            txtCLAVE.Enabled = false;
            lstNIVEL.Enabled = false;
            BMODIFICAR.Focus();

            //Finalizada la busqueda y llenado de campos
            //guardamos el contenido de txtusuario.Text por si se quiere eliminar por medio del usuario
            usuario_eliminar = txtUSUARIO.Text;

        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

            string myInsertQuery = "delete from contactos Where codigo = " + TXTBUSCAR.Text + "";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            MessageBox.Show("Contacto eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


            string consulta = "select * from contactos";

            MySqlConnection conexion = new MySqlConnection(cadena_conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "agenda");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "agenda";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        }






        
        
    
    
