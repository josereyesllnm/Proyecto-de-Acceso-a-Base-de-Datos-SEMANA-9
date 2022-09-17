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
    public partial class CATEGORIASPORTATILES : Form
    {
        public CATEGORIASPORTATILES()
        {
            InitializeComponent();
        }

        //GAMA ALTA PORTATILES
        private void button1_Click(object sender, EventArgs e)
        {
            PortatilesGamaAlta form = new PortatilesGamaAlta();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PortatilesGamaMedia form = new PortatilesGamaMedia();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PortatilesGamaBaja form = new PortatilesGamaBaja();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
