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
            InitializeComponent();
        }

        private void fusuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
