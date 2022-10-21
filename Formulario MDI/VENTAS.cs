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
            txtpreciouni.Enabled = true;
            txtTOTAL.Enabled = true;
            txtfecha.Enabled = true;
            txtcantidad.Enabled = true;
            txtdescuento.Enabled = true;
            txtcliente2.Enabled = true;
            txtfactura.Enabled = true;
            txtvendedor.Enabled = true;
            txttotalventa.Enabled = true;
            txtcodigo2.Enabled = true;
            txtnproducto.Enabled = true;

            try
            {
                string consulta = "select * from detalleventa";

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
            txtpreciouni.Enabled = true;
            txtTOTAL.Enabled = true;
         
            txtpreciouni.Text = "";
            txtTOTAL.Text = "";
            txtfecha.Text = "";
            txtcantidad.Text = "";
            txtdescuento.Text = "";
            txtcliente2.Text = "";
            txtfactura.Text = "";
            txtvendedor.Text = "";
            txttotalventa.Text = "";
            txtcodigo2.Text = "";
            txtnproducto.Text = "";

            txtpreciouni.Focus();
            NUEVO_29.Visible = true;
            GUARDAR_29.Visible = true;
        }

        private void GUARDAR_29_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO detalleventa(fecha,total,cantidad,nfactura,codigo,cliente,vendedor,totalventas,descuento,preciounitario,nombreproducto) Values(?fecha,?total,?cantidad,?nfactura,?codigo,?cliente,?vendedor,?totalventas,?descuento,?preciounitario,?nombreproducto)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?fecha", MySqlDbType.VarChar, 75).Value = txtfecha.Text;
                myCommand.Parameters.Add("?total", MySqlDbType.VarChar, 75).Value = txtTOTAL.Text;
                myCommand.Parameters.Add("?cantidad", MySqlDbType.VarChar, 75).Value = txtcantidad.Text;
                myCommand.Parameters.Add("?descuento", MySqlDbType.VarChar, 75).Value = txtdescuento.Text;
                myCommand.Parameters.Add("?nfactura", MySqlDbType.VarChar, 75).Value = txtfactura.Text;
                myCommand.Parameters.Add("?preciounitario", MySqlDbType.VarChar, 75).Value = txtpreciouni.Text;
                myCommand.Parameters.Add("?cliente", MySqlDbType.VarChar, 75).Value = txtcliente2.Text;
                myCommand.Parameters.Add("?vendedor", MySqlDbType.VarChar, 75).Value = txtvendedor.Text;
                myCommand.Parameters.Add("?totalventas", MySqlDbType.VarChar, 75).Value = txttotalventa.Text;
                myCommand.Parameters.Add("?codigo", MySqlDbType.VarChar, 75).Value = txtcodigo2.Text;
                myCommand.Parameters.Add("?nombreproducto", MySqlDbType.VarChar, 75).Value = txtnproducto.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Venta agregada con éxito", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from detalleventa";

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

            txtpreciouni.Enabled = false;
            txtTOTAL.Enabled = false;            
            txtfecha.Enabled = false;
            txtcantidad.Enabled =false;
            txtdescuento.Enabled = false;
            txtcliente2.Enabled = false;
            txtfactura.Enabled = false;
            txtvendedor.Enabled = false;
            txttotalventa.Enabled = false;
            txtcodigo2.Enabled = false;
            txtnproducto.Enabled = false;

            NUEVO_29.Focus();
        }

        private void ELIMINAR_29_Click(object sender, EventArgs e)
        {
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from detalleventa Where iddetalleventa = " + txtBUSCAR2.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Registro de venta eliminado con éxito", "COMPUTERS GUEVARA", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from detalleventa";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

                venta_eliminar = txtpreciouni.Text;
            }
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            txtpreciouni.Enabled = true;
            txtTOTAL.Enabled = true;
            txtfecha.Enabled = true;
            txtcantidad.Enabled = true;
            txtdescuento.Enabled = true;
            txtcliente2.Enabled = true;
            txtfactura.Enabled = true;
            txtvendedor.Enabled = true;
            txttotalventa.Enabled = true;
            txtcodigo2.Enabled = true;
            txtnproducto.Enabled = true;

            txtpreciouni.Focus();

            BTNMODIFICAR.Visible = true;
            BTNACTUALIZAR.Visible = true;

            venta_modificar = txtpreciouni.Text.ToString();
        }

        private void BTNACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string FEC = txtpreciouni.Text.ToString();
                string TOT = txtTOTAL.Text.ToString();
                



                string myInsertQuery = "UPDATE detalleventa SET fecha = '" + FEC + "', total= '" + TOT + "' WHERE fecha = '" + venta_modificar + "'";

                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);



                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Venta actualizada con éxito", "COMPUTERS GUEVARA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from detalleventa";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al actualizar la venta", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            BTNMODIFICAR.Visible = true;
            BTNACTUALIZAR.Visible = true;
          
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBUSCAR23_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "select * from detalleventa Where iddetalleventa = " + txtBUSCAR2.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);

                myCommand.Connection = myConnection;
                myConnection.Open();

                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txtpreciouni.Text = (myReader.GetString(6));
                    txtTOTAL.Text = (myReader.GetString(11));
                    txtfecha.Text = (myReader.GetString(1));
                    txtcantidad.Text = (myReader.GetString(4));
                    txtdescuento.Text = (myReader.GetString(10));
                    txtcliente2.Text = (myReader.GetString(2));
                    txtfactura.Text = (myReader.GetString(9));
                    txtvendedor.Text = (myReader.GetString(3));
                    txttotalventa.Text = (myReader.GetString(8));
                    txtcodigo2.Text = (myReader.GetString(5));
                    txtnproducto.Text = (myReader.GetString(7));

                }
                else
                {
                    MessageBox.Show("El registro no existe", "COMPUTERS GUEVARA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myReader.Close();
                myConnection.Close();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            NUEVO_29.Visible = true;
            GUARDAR_29.Visible = true;
        }
    }
 }
    
    
    

