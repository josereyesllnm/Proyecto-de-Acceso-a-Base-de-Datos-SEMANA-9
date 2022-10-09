
namespace Formulario_MDI
{
    partial class FUSUARIOS2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUSUARIOS2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCLAVE = new System.Windows.Forms.TextBox();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.lstNIVEL = new System.Windows.Forms.ComboBox();
            this.BPRIMERO = new System.Windows.Forms.Button();
            this.BGUARDAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BELIMINAR = new System.Windows.Forms.Button();
            this.BANTERIOR = new System.Windows.Forms.Button();
            this.BNUEVO = new System.Windows.Forms.Button();
            this.BULTIMO = new System.Windows.Forms.Button();
            this.BSIGUIENTE = new System.Windows.Forms.Button();
            this.BTNMENU = new System.Windows.Forms.Button();
            this.BACTUALIZAR = new System.Windows.Forms.Button();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.TXTBUSCAR = new System.Windows.Forms.TextBox();
            this.BBUSCAR = new System.Windows.Forms.Button();
            this.bTNsalir_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "INGRESO DE USUARIOS AL SISTEMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "USUARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "CLAVE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "NIVEL:";
            // 
            // txtCLAVE
            // 
            this.txtCLAVE.Location = new System.Drawing.Point(222, 141);
            this.txtCLAVE.Multiline = true;
            this.txtCLAVE.Name = "txtCLAVE";
            this.txtCLAVE.Size = new System.Drawing.Size(176, 20);
            this.txtCLAVE.TabIndex = 25;
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(222, 99);
            this.txtUSUARIO.Multiline = true;
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(176, 20);
            this.txtUSUARIO.TabIndex = 23;
            this.txtUSUARIO.TextChanged += new System.EventHandler(this.txtUSUARIO_TextChanged);
            // 
            // lstNIVEL
            // 
            this.lstNIVEL.FormattingEnabled = true;
            this.lstNIVEL.Location = new System.Drawing.Point(222, 178);
            this.lstNIVEL.Name = "lstNIVEL";
            this.lstNIVEL.Size = new System.Drawing.Size(46, 21);
            this.lstNIVEL.TabIndex = 27;
            // 
            // BPRIMERO
            // 
            this.BPRIMERO.BackColor = System.Drawing.Color.LimeGreen;
            this.BPRIMERO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BPRIMERO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPRIMERO.Location = new System.Drawing.Point(152, 263);
            this.BPRIMERO.Name = "BPRIMERO";
            this.BPRIMERO.Size = new System.Drawing.Size(104, 38);
            this.BPRIMERO.TabIndex = 28;
            this.BPRIMERO.Text = "PRIMERO";
            this.BPRIMERO.UseVisualStyleBackColor = false;
            this.BPRIMERO.Click += new System.EventHandler(this.BPRIMERO_Click);
            // 
            // BGUARDAR
            // 
            this.BGUARDAR.BackColor = System.Drawing.Color.LimeGreen;
            this.BGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGUARDAR.Location = new System.Drawing.Point(267, 322);
            this.BGUARDAR.Name = "BGUARDAR";
            this.BGUARDAR.Size = new System.Drawing.Size(104, 38);
            this.BGUARDAR.TabIndex = 31;
            this.BGUARDAR.Text = "GUARDAR ";
            this.BGUARDAR.UseVisualStyleBackColor = false;
            this.BGUARDAR.Click += new System.EventHandler(this.BGUARDAR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 122);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.BackColor = System.Drawing.Color.LimeGreen;
            this.BELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BELIMINAR.Location = new System.Drawing.Point(31, 322);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(104, 38);
            this.BELIMINAR.TabIndex = 33;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = false;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // BANTERIOR
            // 
            this.BANTERIOR.BackColor = System.Drawing.Color.LimeGreen;
            this.BANTERIOR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BANTERIOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BANTERIOR.Location = new System.Drawing.Point(31, 263);
            this.BANTERIOR.Name = "BANTERIOR";
            this.BANTERIOR.Size = new System.Drawing.Size(104, 38);
            this.BANTERIOR.TabIndex = 34;
            this.BANTERIOR.Text = "ANTERIOR ";
            this.BANTERIOR.UseVisualStyleBackColor = false;
            this.BANTERIOR.Click += new System.EventHandler(this.BANTERIOR_Click);
            // 
            // BNUEVO
            // 
            this.BNUEVO.BackColor = System.Drawing.Color.LimeGreen;
            this.BNUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BNUEVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNUEVO.Location = new System.Drawing.Point(31, 382);
            this.BNUEVO.Name = "BNUEVO";
            this.BNUEVO.Size = new System.Drawing.Size(104, 38);
            this.BNUEVO.TabIndex = 36;
            this.BNUEVO.Text = "NUEVO ";
            this.BNUEVO.UseVisualStyleBackColor = false;
            this.BNUEVO.Click += new System.EventHandler(this.BNUEVO_Click);
            // 
            // BULTIMO
            // 
            this.BULTIMO.BackColor = System.Drawing.Color.LimeGreen;
            this.BULTIMO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BULTIMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BULTIMO.Location = new System.Drawing.Point(377, 263);
            this.BULTIMO.Name = "BULTIMO";
            this.BULTIMO.Size = new System.Drawing.Size(104, 38);
            this.BULTIMO.TabIndex = 37;
            this.BULTIMO.Text = "ULTIMO";
            this.BULTIMO.UseVisualStyleBackColor = false;
            this.BULTIMO.Click += new System.EventHandler(this.BULTIMO_Click);
            // 
            // BSIGUIENTE
            // 
            this.BSIGUIENTE.BackColor = System.Drawing.Color.LimeGreen;
            this.BSIGUIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSIGUIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSIGUIENTE.Location = new System.Drawing.Point(267, 263);
            this.BSIGUIENTE.Name = "BSIGUIENTE";
            this.BSIGUIENTE.Size = new System.Drawing.Size(104, 38);
            this.BSIGUIENTE.TabIndex = 40;
            this.BSIGUIENTE.Text = "SIGUIENTE ";
            this.BSIGUIENTE.UseVisualStyleBackColor = false;
            this.BSIGUIENTE.Click += new System.EventHandler(this.BSIGUIENTE_Click);
            // 
            // BTNMENU
            // 
            this.BTNMENU.BackColor = System.Drawing.Color.LimeGreen;
            this.BTNMENU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNMENU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMENU.Location = new System.Drawing.Point(47, 127);
            this.BTNMENU.Name = "BTNMENU";
            this.BTNMENU.Size = new System.Drawing.Size(62, 41);
            this.BTNMENU.TabIndex = 41;
            this.BTNMENU.Text = "MENU";
            this.BTNMENU.UseVisualStyleBackColor = false;
            this.BTNMENU.Click += new System.EventHandler(this.BTNMENU_Click);
            // 
            // BACTUALIZAR
            // 
            this.BACTUALIZAR.BackColor = System.Drawing.Color.LimeGreen;
            this.BACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BACTUALIZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACTUALIZAR.Location = new System.Drawing.Point(267, 382);
            this.BACTUALIZAR.Name = "BACTUALIZAR";
            this.BACTUALIZAR.Size = new System.Drawing.Size(104, 38);
            this.BACTUALIZAR.TabIndex = 42;
            this.BACTUALIZAR.Text = "ACTUALIZAR";
            this.BACTUALIZAR.UseVisualStyleBackColor = false;
            this.BACTUALIZAR.Click += new System.EventHandler(this.BACTUALIZAR_Click);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.BackColor = System.Drawing.Color.LimeGreen;
            this.BMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BMODIFICAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMODIFICAR.Location = new System.Drawing.Point(152, 322);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(104, 38);
            this.BMODIFICAR.TabIndex = 43;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = false;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // TXTBUSCAR
            // 
            this.TXTBUSCAR.Location = new System.Drawing.Point(557, 62);
            this.TXTBUSCAR.Multiline = true;
            this.TXTBUSCAR.Name = "TXTBUSCAR";
            this.TXTBUSCAR.Size = new System.Drawing.Size(207, 24);
            this.TXTBUSCAR.TabIndex = 44;
            // 
            // BBUSCAR
            // 
            this.BBUSCAR.BackColor = System.Drawing.Color.LimeGreen;
            this.BBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BBUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBUSCAR.Location = new System.Drawing.Point(613, 91);
            this.BBUSCAR.Name = "BBUSCAR";
            this.BBUSCAR.Size = new System.Drawing.Size(104, 38);
            this.BBUSCAR.TabIndex = 45;
            this.BBUSCAR.Text = "BUSCAR";
            this.BBUSCAR.UseVisualStyleBackColor = false;
            this.BBUSCAR.Click += new System.EventHandler(this.BBUSCAR_Click);
            // 
            // bTNsalir_Click
            // 
            this.bTNsalir_Click.BackColor = System.Drawing.Color.LimeGreen;
            this.bTNsalir_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bTNsalir_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTNsalir_Click.Location = new System.Drawing.Point(377, 322);
            this.bTNsalir_Click.Name = "bTNsalir_Click";
            this.bTNsalir_Click.Size = new System.Drawing.Size(104, 38);
            this.bTNsalir_Click.TabIndex = 46;
            this.bTNsalir_Click.Text = "SALIR";
            this.bTNsalir_Click.UseVisualStyleBackColor = false;
            this.bTNsalir_Click.Click += new System.EventHandler(this.bTNsalir_Click_Click);
            // 
            // FUSUARIOS2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.bTNsalir_Click);
            this.Controls.Add(this.BBUSCAR);
            this.Controls.Add(this.TXTBUSCAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.BACTUALIZAR);
            this.Controls.Add(this.BTNMENU);
            this.Controls.Add(this.BSIGUIENTE);
            this.Controls.Add(this.BULTIMO);
            this.Controls.Add(this.BNUEVO);
            this.Controls.Add(this.BANTERIOR);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BGUARDAR);
            this.Controls.Add(this.BPRIMERO);
            this.Controls.Add(this.lstNIVEL);
            this.Controls.Add(this.txtCLAVE);
            this.Controls.Add(this.txtUSUARIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FUSUARIOS2";
            this.Text = "FORMULARIO DE MYSQL";
            this.Load += new System.EventHandler(this.FUSUARIOS2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCLAVE;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.ComboBox lstNIVEL;
        private System.Windows.Forms.Button BPRIMERO;
        private System.Windows.Forms.Button BGUARDAR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BELIMINAR;
        private System.Windows.Forms.Button BANTERIOR;
        private System.Windows.Forms.Button BNUEVO;
        private System.Windows.Forms.Button BULTIMO;
        private System.Windows.Forms.Button BSIGUIENTE;
        private System.Windows.Forms.Button BTNMENU;
        private System.Windows.Forms.Button BACTUALIZAR;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.TextBox TXTBUSCAR;
        private System.Windows.Forms.Button BBUSCAR;
        private System.Windows.Forms.Button bTNsalir_Click;
    }
}