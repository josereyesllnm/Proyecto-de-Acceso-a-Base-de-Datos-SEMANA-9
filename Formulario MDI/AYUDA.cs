using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class AYUDA : Form
    {
        public AYUDA()
        {
            InitializeComponent();
        }


     
        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de enviar su solicitud de ayuda?", " Confirmacion de Solicitud", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            MessageBox.Show(" Muchas Gracias por enviar su solicitud de ayuda trataremos de   solucionar sus interrogantes lo mas pronto posible.                                                     "
                +


                   "           Su solicitud ha sido enviada correctamente!!", " Computers Guevara.");
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
