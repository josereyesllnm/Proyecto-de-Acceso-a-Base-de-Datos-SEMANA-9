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
        public string usuario_eliminar;


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

        private void GUARDAR_23_Click(object sender, EventArgs e)
        {

        }
    }
  }

