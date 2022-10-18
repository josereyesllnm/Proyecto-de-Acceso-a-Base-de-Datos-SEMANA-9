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
    public partial class PROVEEDORES : Form
    {


        public string cadena_cone = "Database=agenda;Data Source=localhost;User Id=jose;Password=12345";
        public string proveedor_eliminar;
        public string proveedor_modificar;
        public string proveedor_actualizar;
        public PROVEEDORES()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PROVEEDORES_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "select * from proveedores";

                MySqlConnection conexion = new MySqlConnection(cadena_cone);
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
    

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void NUEVO_24_Click(object sender, EventArgs e)
        {

            txtnombree.Enabled = true;
            txtcodigo.Enabled = true;
            txtempresa.Enabled = true;
            txtnombree.Text = "";
            txtcodigo.Text = "";
            txtempresa.Text = "";
            txtnombree.Focus();
            NUEVO_24.Visible = true;
            GUARDAR_24.Visible = true;
        }

        private void GUARDAR_24_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_cone);

                string myInsertQuery = "INSERT INTO proveedores(nombres,codigo,empresa) Values(?nombres,?codigo,?empresa)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?nombres", MySqlDbType.VarChar, 75).Value = txtnombree.Text;
                myCommand.Parameters.Add("?codigo", MySqlDbType.VarChar, 75).Value = txtcodigo.Text;
                myCommand.Parameters.Add("?empresa", MySqlDbType.VarChar, 75).Value = txtempresa.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Agregado con éxito", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from proveedores";

                MySqlConnection conexion = new MySqlConnection(cadena_cone);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el proveedor", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_cone);

                string myInsertQuery = "select * from proveedores Where idproveedor = " + txtBuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);

                myCommand.Connection = myConnection;
                myConnection.Open();

                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txtnombree.Text = (myReader.GetString(1));
                    txtcodigo.Text = (myReader.GetString(2));
                    txtempresa.Text = (myReader.GetString(3));
                }
                else
                {
                    MessageBox.Show("El proveedor no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myReader.Close();
                myConnection.Close();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

 
        }

        private void BTNELIMINAR1_Click(object sender, EventArgs e)
        {
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_cone);

                string myInsertQuery = "delete from proveedores Where codigo = " + txtBuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Proveedor eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from proveedores";

                MySqlConnection conexion = new MySqlConnection(cadena_cone);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

                proveedor_eliminar = txtnombree.Text;
            }
        }

        private void BTNACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_cone);

                string nom = txtnombree.Text.ToString();
                string cod = txtcodigo.Text.ToString();
                string emp = txtempresa.Text; ToString();


                
                string myInsertQuery = "UPDATE proveedores SET nombre = '" + nom + "', codigo = '" + cod + "',empresa = '" + emp + "' WHERE nombre = '" + proveedor_modificar + "'";

                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

          

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("proveedor actualizado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from proveedores";

                MySqlConnection conexion = new MySqlConnection(cadena_cone);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "proveedores");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "proveedores";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al actualizar al proveedor", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            BTNMODIFICAR.Visible = true;
            BTNACTUALIZAR.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtnombree.Enabled = false;
            txtcodigo.Enabled = false;
            txtempresa.Enabled = false;
            BTNMODIFICAR.Focus();

        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            txtnombree.Enabled = true;
            txtcodigo.Enabled = true;
            txtempresa.Enabled = true;

            txtnombree.Focus();

            BTNMODIFICAR.Visible = false;
            BTNACTUALIZAR.Visible = true;

            proveedor_modificar = txtnombree.Text.ToString();
        }
    }
        }
    
    

