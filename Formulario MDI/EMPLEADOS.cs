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
    public partial class EMPLEADOS : Form
    {

        public string cadena_conexion = "Database=agenda;Data Source=Localhost;User Id=jose;Password=12345";
        public string empleados_eliminar;
        public string empleados_modificar;
        public string empleados_actualizar;



        public EMPLEADOS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EMPLEADOS_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "select * from empleados";

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

        private void GUARDAR25_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO empleados(nombre,apellidos,celular) Values(?nombre,?apellidos,?celular)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtNOMBREE.Text;
                myCommand.Parameters.Add("?apellidos", MySqlDbType.VarChar, 75).Value = txtAPELLIDOOS.Text;
                myCommand.Parameters.Add("?celular", MySqlDbType.VarChar, 75).Value = txtCELULAAR.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Agregado con éxito", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from empleados";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el EMPLEADO", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            NUEVO_25.Visible = true;
            GUARDAR25.Visible = true;

            txtNOMBREE.Enabled = false;
            txtAPELLIDOOS.Enabled = false;
            txtCELULAAR.Enabled = false;
            NUEVO_25.Focus();
        }

        private void NUEVO_25_Click(object sender, EventArgs e)
        {
            txtNOMBREE.Enabled = true;
            txtAPELLIDOOS.Enabled = true;
            txtCELULAAR.Enabled = true;
            txtNOMBREE.Text = "";
            txtAPELLIDOOS.Text = "";
            txtCELULAAR.Text = "";
            txtNOMBREE.Focus();
            NUEVO_25.Visible = true;
            GUARDAR25.Visible = true;
        }

        private void BTNELIMINAR1_Click(object sender, EventArgs e)
        {

        }

        private void BTNELIMINAR2_Click(object sender, EventArgs e)
        {
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from empleados Where codigo = " + txtBUSCAR23.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("EMPLEADO eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from empleados";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

                empleados_eliminar = txtNOMBREE.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "select * from empleados Where idempleado = " + txtBUSCAR23.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);

                myCommand.Connection = myConnection;
                myConnection.Open();

                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txtNOMBREE.Text = (myReader.GetString(1));
                    txtAPELLIDOOS.Text = (myReader.GetString(2));
                    txtCELULAAR.Text = (myReader.GetString(3));
                }
                else
                {
                    MessageBox.Show("El EMPLEADO no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myReader.Close();
                myConnection.Close();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            NUEVO_25.Visible = true;
            GUARDAR25.Visible = true;
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            txtNOMBREE.Enabled = true;
            txtAPELLIDOOS.Enabled = true;
            txtCELULAAR.Enabled = true;

            txtNOMBREE.Focus();

            BTNMODIFICAR.Visible = false;
            BTNACTUALIZAR.Visible = true;

            empleados_modificar = txtNOMBREE.Text.ToString();
        }

        private void BTNACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string nom = txtNOMBREE.Text.ToString();
                string ape = txtAPELLIDOOS.Text.ToString();
                string cel = txtCELULAAR.Text; ToString();



                string myInsertQuery = "UPDATE empleados SET nombre = '" + nom + "', apellidos= '" + ape + "',celular = '" + cel+ "' WHERE nombre = '" + empleados_modificar + "'";

                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);



                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("empleado actualizado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from empleados";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "empleados");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "empleados";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al actualizar al empleado", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            BTNMODIFICAR.Visible = true;
            BTNACTUALIZAR.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtNOMBREE.Enabled = false;
            txtAPELLIDOOS.Enabled = false;
            txtCELULAAR.Enabled = false;
            BTNMODIFICAR.Focus();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }
    

    

