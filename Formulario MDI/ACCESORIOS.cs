using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class ACCESORIOS : Form
    {
        public ACCESORIOS()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Comprar este combo?", " Confirmacion de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Comprar esta USB?", " Confirmacion de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show(" Muchas Gracias por visitar nuestro sitio.                                                     "
                +
                   "           Su compra ha sido un exito!!", " Computers Guevara.");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Comprar este teclado?", " Confirmacion de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show(" Muchas Gracias por visitar nuestro sitio.                                                     "
                +
                   "           Su compra ha sido un exito!!", " Computers Guevara.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Comprar este Mouse?", " Confirmacion de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show(" Muchas Gracias por visitar nuestro sitio.                                                     "
                +
                   "           Su compra ha sido un exito!!", " Computers Guevara.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Comprar esta Camara Web?", " Confirmacion de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show(" Muchas Gracias por visitar nuestro sitio.                                                     "
                +
                   "           Su compra ha sido un exito!!", " Computers Guevara.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Comprar estos Audifonos?", " Confirmacion de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show(" Muchas Gracias por visitar nuestro sitio.                                                     "
                +
                   "           Su compra ha sido un exito!!", " Computers Guevara.");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Comprar este Mouse Pad?", " Confirmacion de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show(" Muchas Gracias por visitar nuestro sitio.                                                     "
                +
                   "           Su compra ha sido un exito!!", " Computers Guevara.");
        }

        private void ACCESORIOS_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
