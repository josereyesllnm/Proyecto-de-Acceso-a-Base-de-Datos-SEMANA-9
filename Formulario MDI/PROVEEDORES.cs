using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Formulario_MDI
{
    public partial class PROVEEDORES : Form
    {


        public string cadena_conexion = "Database=agenda;Data Source=Localhost;User Id=Maydelin;Password=Aliciaperdomo2508";
        public string proveedor_eliminar;
        
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
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO proveedor(Nombre,codigo,empresa) Values(?Nombre,?codigo,?empresa)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?Nombre", MySqlDbType.VarChar, 75).Value = txtnombree;
                myCommand.Parameters.Add("?codigo", MySqlDbType.VarChar, 75).Value = txtcodigo;
                myCommand.Parameters.Add("?empresa", MySqlDbType.VarChar, 75).Value = txtempresa;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Agregado con éxito", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from proveedor";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
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
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "select * from proveedor Where idproveedor = " + btnbuscar.Text + "";
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
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from proveedor Where codigo = " + txtBuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Proveedor eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from proveedor";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

                proveedor_eliminar = txtnombree.Text;
            }
        }
    }
    }

