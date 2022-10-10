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

        public string cadena_conexion = "Database=agenda;Data Source=Localhost;User Id=jose;Password=12345";
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
                string consulta = "select * from cliente";

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

                string myInsertQuery = "INSERT INTO cliente(nombres,apellidos,celular) Values(?nombres,?apellidos,?celular)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?nombres", MySqlDbType.VarChar, 75).Value = txtnombre;
                myCommand.Parameters.Add("?apellidos", MySqlDbType.VarChar, 75).Value = txtapellidos;
                myCommand.Parameters.Add("?celular", MySqlDbType.VarChar, 75).Value = txtcelular;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Agregado con éxito", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from cliente";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el cliente", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            NUEVO_23.Visible = true;
            GUARDAR_23.Visible = true;

            txtnombre.Enabled = false;
            txtapellidos.Enabled = false;
            txtcelular.Enabled = false;
            NUEVO_23.Focus();
        }
          
 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NUEVO_23_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            txtapellidos.Enabled = true;
            txtcelular.Enabled = true;
            txtnombre.Text = "";
            txtapellidos.Text = "";
            txtcelular.Text = "";
            txtnombre.Focus();
            NUEVO_23.Visible = true;
            GUARDAR_23.Visible = true;
        }

        private void txttbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "select * from cliente Where idcliente = " + bbtnbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);

                myCommand.Connection = myConnection;
                myConnection.Open();

                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txtnombre.Text = (myReader.GetString(1));
                    txtapellidos.Text = (myReader.GetString(2));
                    txtcelular.Text = (myReader.GetString(3));
                }
                else
                {
                    MessageBox.Show("El Cliente no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myReader.Close();
                myConnection.Close();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            NUEVO_23.Visible = true;
            GUARDAR_23.Visible = false;
        }

        private void ELIMINAR_23_Click_1(object sender, EventArgs e)
        {
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from cliente Where codigo = " + txttbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Cliente eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from cliente";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

                cliente_eliminar = txtnombre.Text;
            }
        }
    }
  }

