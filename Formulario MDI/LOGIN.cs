﻿using System;
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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fusuarios form = new fusuarios();
            form.ShowDialog();
        }

        private void btnentrarusuario_sqlserver_Click(object sender, EventArgs e)
        {

        }

        private void bentrar_access_Click_Click(object sender, EventArgs e)
        {
            
        }
    }
}
