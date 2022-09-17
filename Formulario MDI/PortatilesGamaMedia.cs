using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class PortatilesGamaMedia : Form
    {
        public PortatilesGamaMedia()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Comprar este Postre?", " Confirmacion de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show(" Muchas Gracias por visitar nuestro sitio.                                                     "
                   +
                      "           Su compra ha sido un exito!!", " Computers Guevara.");

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Comprar esta Computadora?", " Confirmacion de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            MessageBox.Show(" Muchas Gracias por visitar nuestro sitio.                                                     "
                +
                   "           Su compra ha sido un exito!!", " Computers Guevara.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Comprar esta Computadora?", " Confirmacion de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            MessageBox.Show(" Muchas Gracias por visitar nuestro sitio.                                                     "
                +
                   "           Su compra ha sido un exito!!", " Computers Guevara.");
        }
    }
}
