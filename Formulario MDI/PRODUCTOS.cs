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
    public partial class EquiposDeEscritorio : Form
    {
        public EquiposDeEscritorio()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CATEGORIASESCRITORIOS form = new CATEGORIASESCRITORIOS();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CATEGORIASPORTATILES form = new CATEGORIASPORTATILES();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ACCESORIOS form = new ACCESORIOS();
            form.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
