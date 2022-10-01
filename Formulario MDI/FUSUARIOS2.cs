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
    public partial class FUSUARIOS2 : Form
    {
        public FUSUARIOS2()
        {
            InitializeComponent();
        }

        private void BTNMENU_Click(object sender, EventArgs e)
        {
            MENU fprincipal = new MENU();
            fprincipal.Show();
        }

        private void bTNsalir_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BANTERIOR_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.MovePrevious();
        }

        private void BPRIMERO_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.MoveFirst();
        }
    }
}
