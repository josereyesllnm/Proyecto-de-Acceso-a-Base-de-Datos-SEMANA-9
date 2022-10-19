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
    public partial class VENTAS : Form
    {

        public string cadena_conexion = "Database=agenda;Data Source=Localhost;User Id=jose;Password=12345";
        public string venta_eliminar;
        public string venta_modificar;
        public string venta_actualizar;


        public VENTAS()
        {
            InitializeComponent();
        }

        private void VENTAS_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "select * from ventas";

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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NUEVO_29_Click(object sender, EventArgs e)
        {
            txtFECHA.Enabled = true;
            txtTOTAL.Enabled = true;
         
            txtFECHA.Text = "";
            txtTOTAL.Text = "";
            txtFECHA.Focus();
            NUEVO_29.Visible = true;
            GUARDAR_29.Visible = true;
        }

        private void GUARDAR_29_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO ventas(fecha,total) Values(?fecha,?total)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?fecha", MySqlDbType.Date, 50).Value = txtFECHA.Text;
                myCommand.Parameters.Add("?total", MySqlDbType.VarChar, 75).Value = txtTOTAL.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Agregado con éxito", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from ventas";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe este registro en ventas", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            NUEVO_29.Visible = true;
            GUARDAR_29.Visible = true;

            txtFECHA.Enabled = false;
            txtTOTAL.Enabled = false;
       
            NUEVO_29.Focus();
        }

        private void ELIMINAR_29_Click(object sender, EventArgs e)
        {
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from ventas Where codigo = " + txtBUSCAR2.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Registro de venta eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from ventas";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

                venta_eliminar = txtFECHA.Text;
            }
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            txtFECHA.Enabled = true;
            txtTOTAL.Enabled = true;
        

            txtFECHA.Focus();

            BTNMODIFICAR.Visible = false;
            BTNACTUALIZAR.Visible = true;

            venta_modificar = txtFECHA.Text.ToString();
        }

        private void BTNACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string FEC = txtFECHA.Text.ToString();
                string TOT = txtTOTAL.Text.ToString();
                



                string myInsertQuery = "UPDATE ventas SET fecha = '" + FEC + "', total= '" + TOT + "' WHERE fecha = '" + venta_modificar + "'";

                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);



                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("venta actualizada con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from ventas";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "ventas");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ventas";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al actualizar la venta", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            BTNMODIFICAR.Visible = true;
            BTNACTUALIZAR.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtFECHA.Enabled = false;
            txtTOTAL.Enabled = false;
           
            BTNMODIFICAR.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }
    
    

