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
    public partial class CATEGORIASESCRITORIOS : Form
    {
        public CATEGORIASESCRITORIOS()
        {
            InitializeComponent();
        }

        private void CATEGORIASESCRITORIOS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EscritorioGamaAlta form = new EscritorioGamaAlta();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EscritorioGamaMedia form = new EscritorioGamaMedia();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EscritorioGamaBaja form = new EscritorioGamaBaja();
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
