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
    public partial class fusuarios : Form
    {
        // Crear la variable para la conexión
        public OleDbConnection miconexion;
        // Crear la variable para saber cuál actualizar
        public string usuario_modificar;


        public fusuarios()
        {
            miconexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.4.0;DataSource=C:\Sistema\sistema.mdb");

            InitializeComponent();
        }

        private void fusuarios_Load(object sender, EventArgs e)
        {
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;

            this.tusuariosTableAdapter.Fill(this.sistemaDataSet.tusuarios);

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void bprimero_Click_Click(object sender, EventArgs e)
        {
            this.tusuariosBindingSource.MoveFirst();
        }

        private void banterior_Click_Click(object sender, EventArgs e)
        {
            this.tusuariosBindingSource.MovePrevious();
        }

        private void bsiguiente_Click_Click(object sender, EventArgs e)
        {
            this.tusuariosBindingSource.MoveNext();
        }

        private void bultimo_Click_Click(object sender, EventArgs e)
        {
            this.tusuariosBindingSource.MoveLast();
        }

        private void bnuevo_Click_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txtusuario.Focus();
            bnuevo_Click.Visible = false;
            bguardar_Click.Visible = true;
        }

        private void bguardar_Click_Click(object sender, EventArgs e)
        {
            try{
                OleDbCommand guardar = new OleDbCommand();
                miconexion.Open();
                guardar.Connection = miconexion;
                guardar.CommandType = CommandType.Text;
                guardar.CommandText = "INSERT INTO tusuario ([nombre], [clave],[nivel])Values('" + txtusuario.Text.ToString() + "', '" +
                txtclave.Text.ToString() + "','" + lstnivel.Text.ToString() + "')";

                guardar.ExecuteNonQuery();
                miconexion.Close();
                bnuevo_Click.Visible = true;
                bguardar_Click.Visible = false;
              
                //Deshabilitar campos, se activan al crear nuevo registro.
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;
                bnuevo_Click.Focus();
                
                //Mensaje que se guardó correctamente
                MessageBox.Show("Usuario agregado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tusuariosTableAdapter.Fill(this.sistemaDataSet.tusuarios);
                this.tusuariosBindingSource.MoveLast();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void bmodificar_Click_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Focus();
            bmodificar_Click.Visible = false;
            bactualizar_Click.Visible = true;
            usuario_modificar = txtusuario.Text.ToString();
        }

        private void bactualizar_Click_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand actualizar = new OleDbCommand();
                miconexion.Open();
                actualizar.Connection = miconexion;
                actualizar.CommandType = CommandType.Text;
                
                string nom = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text;
               
                //Podemos actualizar todos los campos de una vez
                actualizar.CommandText = "UPDATE tusuario SET nombre = '" + nom + "',clave = '" + cla + "',nivel = '" + niv + "' WHERE nombre = '" + usuario_modificar + "'";
                miconexion.Close();
                bmodificar_Click.Visible = true;
                bactualizar_Click.Visible = false;
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;
               
                //Mensaje que se guardó correctamente
                MessageBox.Show("Usuario actualizado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                //this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void beliminar_Click_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand eliminar = new OleDbCommand();
                miconexion.Open();
                eliminar.Connection = miconexion;
                eliminar.CommandType = CommandType.Text;
                eliminar.CommandText = "DELETE FROM tusuario WHERE nombre = '" + txtusuario.Text.ToString() + "'";

                eliminar.ExecuteNonQuery();
                this.tusuariosBindingSource.MoveNext();
                miconexion.Close();

                //Mensaje que se guardó correctamente
                MessageBox.Show("Usuario eliminado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);
                this.tusuariosBindingSource.MovePrevious();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bsalir_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
 }
    



