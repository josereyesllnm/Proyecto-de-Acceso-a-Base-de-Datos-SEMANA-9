using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ACERCADE f2 = new ACERCADE();
            f2.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opcion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();
            f2.ShowDialog();
        }

        private void opcion2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OfertasDelMes f7 = new OfertasDelMes();
            f7.ShowDialog();
        }

        private void menu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        private void opcion3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ACCESORIOS f8 = new ACCESORIOS();
            f8.ShowDialog();
        }

   

       

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gamaltaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscritorioGamaAlta f12 = new EscritorioGamaAlta();
            f12.ShowDialog();

        }

        private void gamamediaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscritorioGamaMedia f13 = new EscritorioGamaMedia();
            f13.ShowDialog();

        }

        private void gamabajaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscritorioGamaBaja f14 = new EscritorioGamaBaja();
            f14.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AYUDA f3 = new AYUDA();
            f3.ShowDialog();
        }

        private void cATEGORIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscritorioGamaAlta f12 = new EscritorioGamaAlta();
            f12.ShowDialog();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            EscritorioGamaAlta f12 = new EscritorioGamaAlta();
            f12.ShowDialog();
        }

        private void equposDeEscritorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquiposDeEscritorio form = new EquiposDeEscritorio();
            form.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CLIENTES form = new CLIENTES();
            form.ShowDialog();
        }

      
        
        private void pROVEEDORESToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PROVEEDORES form = new PROVEEDORES();
            form.ShowDialog();
        }

        private void fACTURACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FACTURACION form = new FACTURACION();
            form.ShowDialog();
        }
    }

}
