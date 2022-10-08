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
    public partial class CLIENTES : Form
    {

        public string cadena_conexion = "Database=agenda;Data Source=Localhost;User Id=Maydelin;Password=Aliciaperdomo2508";
        public string cliente_eliminar;


        public CLIENTES()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CLIENTES_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "select * from clientes";

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

        private void GUARDAR_23_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO Clientes(Nombre,Clave,Nivel) Values(?Nombre,?Clave,?Nivel)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?Nombre", MySqlDbType.VarChar, 75).Value = dataGridView1;
                myCommand.Parameters.Add("?Clave", MySqlDbType.VarChar, 75).Value = dataGridView1;
                myCommand.Parameters.Add("?Nivel", MySqlDbType.VarChar, 75).Value = dataGridView1;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Contacto agregado con éxito", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from clientes";

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
        }

        private void ELIMINAR_23_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
  }

