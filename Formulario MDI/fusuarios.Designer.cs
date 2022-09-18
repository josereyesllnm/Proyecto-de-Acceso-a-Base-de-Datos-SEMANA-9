
namespace Formulario_MDI
{
    partial class fusuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fusuarios));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.tusuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaDataSet = new Formulario_MDI.sistemaDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.tusuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.banterior_Click = new System.Windows.Forms.Button();
            this.bsiguiente_Click = new System.Windows.Forms.Button();
            this.bultimo_Click = new System.Windows.Forms.Button();
            this.beliminar_Click = new System.Windows.Forms.Button();
            this.bmodificar_Click = new System.Windows.Forms.Button();
            this.bsalir_Click = new System.Windows.Forms.Button();
            this.bguardar_Click = new System.Windows.Forms.Button();
            this.bactualizar_Click = new System.Windows.Forms.Button();
            this.tusuariosTableAdapter = new Formulario_MDI.sistemaDataSetTableAdapters.tusuariosTableAdapter();
            this.bprimero_Click = new System.Windows.Forms.Button();
            this.bnuevo_Click = new System.Windows.Forms.Button();
            this.tusuariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tusuariosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bmmmenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuariosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuariosBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtusuario
            // 
            this.txtusuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tusuariosBindingSource, "nombre", true));
            this.txtusuario.Location = new System.Drawing.Point(202, 88);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(173, 20);
            this.txtusuario.TabIndex = 11;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // tusuariosBindingSource
            // 
            this.tusuariosBindingSource.DataMember = "tusuarios";
            this.tusuariosBindingSource.DataSource = this.sistemaDataSet;
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "sistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "USUARIO:";
            // 
            // txtclave
            // 
            this.txtclave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tusuariosBindingSource1, "clave", true));
            this.txtclave.Location = new System.Drawing.Point(202, 140);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(173, 20);
            this.txtclave.TabIndex = 14;
            // 
            // tusuariosBindingSource1
            // 
            this.tusuariosBindingSource1.DataMember = "tusuarios";
            this.tusuariosBindingSource1.DataSource = this.sistemaDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "CLAVE:";
            // 
            // lstnivel
            // 
            this.lstnivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tusuariosBindingSource1, "nivel", true));
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Location = new System.Drawing.Point(202, 188);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(173, 21);
            this.lstnivel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "NIVEL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "INGRESO DE USUARIOS AL SISTEMA";
            // 
            // banterior_Click
            // 
            this.banterior_Click.BackColor = System.Drawing.Color.Gold;
            this.banterior_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.banterior_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banterior_Click.Location = new System.Drawing.Point(132, 263);
            this.banterior_Click.Name = "banterior_Click";
            this.banterior_Click.Size = new System.Drawing.Size(85, 43);
            this.banterior_Click.TabIndex = 20;
            this.banterior_Click.Text = "ANTERIOR";
            this.banterior_Click.UseVisualStyleBackColor = false;
            this.banterior_Click.Click += new System.EventHandler(this.banterior_Click_Click);
            // 
            // bsiguiente_Click
            // 
            this.bsiguiente_Click.BackColor = System.Drawing.Color.Gold;
            this.bsiguiente_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bsiguiente_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiguiente_Click.Location = new System.Drawing.Point(232, 263);
            this.bsiguiente_Click.Name = "bsiguiente_Click";
            this.bsiguiente_Click.Size = new System.Drawing.Size(85, 43);
            this.bsiguiente_Click.TabIndex = 21;
            this.bsiguiente_Click.Text = "SIGUIENTE";
            this.bsiguiente_Click.UseVisualStyleBackColor = false;
            this.bsiguiente_Click.Click += new System.EventHandler(this.bsiguiente_Click_Click);
            // 
            // bultimo_Click
            // 
            this.bultimo_Click.BackColor = System.Drawing.Color.Gold;
            this.bultimo_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bultimo_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bultimo_Click.Location = new System.Drawing.Point(332, 263);
            this.bultimo_Click.Name = "bultimo_Click";
            this.bultimo_Click.Size = new System.Drawing.Size(85, 43);
            this.bultimo_Click.TabIndex = 22;
            this.bultimo_Click.Text = "ULTIMO";
            this.bultimo_Click.UseVisualStyleBackColor = false;
            this.bultimo_Click.Click += new System.EventHandler(this.bultimo_Click_Click);
            // 
            // beliminar_Click
            // 
            this.beliminar_Click.BackColor = System.Drawing.Color.Gold;
            this.beliminar_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.beliminar_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar_Click.Location = new System.Drawing.Point(132, 323);
            this.beliminar_Click.Name = "beliminar_Click";
            this.beliminar_Click.Size = new System.Drawing.Size(85, 43);
            this.beliminar_Click.TabIndex = 24;
            this.beliminar_Click.Text = "ELIMINAR";
            this.beliminar_Click.UseVisualStyleBackColor = false;
            this.beliminar_Click.Click += new System.EventHandler(this.beliminar_Click_Click);
            // 
            // bmodificar_Click
            // 
            this.bmodificar_Click.BackColor = System.Drawing.Color.Gold;
            this.bmodificar_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bmodificar_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodificar_Click.Location = new System.Drawing.Point(232, 323);
            this.bmodificar_Click.Name = "bmodificar_Click";
            this.bmodificar_Click.Size = new System.Drawing.Size(85, 43);
            this.bmodificar_Click.TabIndex = 25;
            this.bmodificar_Click.Text = "MODIFICAR";
            this.bmodificar_Click.UseVisualStyleBackColor = false;
            this.bmodificar_Click.Click += new System.EventHandler(this.bmodificar_Click_Click);
            // 
            // bsalir_Click
            // 
            this.bsalir_Click.BackColor = System.Drawing.Color.Gold;
            this.bsalir_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bsalir_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir_Click.Location = new System.Drawing.Point(332, 323);
            this.bsalir_Click.Name = "bsalir_Click";
            this.bsalir_Click.Size = new System.Drawing.Size(85, 43);
            this.bsalir_Click.TabIndex = 26;
            this.bsalir_Click.Text = "SALIR";
            this.bsalir_Click.UseVisualStyleBackColor = false;
            this.bsalir_Click.Click += new System.EventHandler(this.bsalir_Click_Click);
            // 
            // bguardar_Click
            // 
            this.bguardar_Click.BackColor = System.Drawing.Color.Gold;
            this.bguardar_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bguardar_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar_Click.Location = new System.Drawing.Point(31, 386);
            this.bguardar_Click.Name = "bguardar_Click";
            this.bguardar_Click.Size = new System.Drawing.Size(85, 43);
            this.bguardar_Click.TabIndex = 27;
            this.bguardar_Click.Text = "GUARDAR";
            this.bguardar_Click.UseVisualStyleBackColor = false;
            this.bguardar_Click.Click += new System.EventHandler(this.bguardar_Click_Click);
            // 
            // bactualizar_Click
            // 
            this.bactualizar_Click.BackColor = System.Drawing.Color.Gold;
            this.bactualizar_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bactualizar_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bactualizar_Click.Location = new System.Drawing.Point(232, 386);
            this.bactualizar_Click.Name = "bactualizar_Click";
            this.bactualizar_Click.Size = new System.Drawing.Size(93, 43);
            this.bactualizar_Click.TabIndex = 28;
            this.bactualizar_Click.Text = "ACTUALIZAR";
            this.bactualizar_Click.UseVisualStyleBackColor = false;
            this.bactualizar_Click.Click += new System.EventHandler(this.bactualizar_Click_Click);
            // 
            // tusuariosTableAdapter
            // 
            this.tusuariosTableAdapter.ClearBeforeFill = true;
            // 
            // bprimero_Click
            // 
            this.bprimero_Click.BackColor = System.Drawing.Color.Gold;
            this.bprimero_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bprimero_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprimero_Click.Location = new System.Drawing.Point(31, 263);
            this.bprimero_Click.Name = "bprimero_Click";
            this.bprimero_Click.Size = new System.Drawing.Size(85, 43);
            this.bprimero_Click.TabIndex = 29;
            this.bprimero_Click.Text = "PRIMERO";
            this.bprimero_Click.UseVisualStyleBackColor = false;
            this.bprimero_Click.Click += new System.EventHandler(this.bprimero_Click_Click);
            // 
            // bnuevo_Click
            // 
            this.bnuevo_Click.BackColor = System.Drawing.Color.Gold;
            this.bnuevo_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnuevo_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevo_Click.Location = new System.Drawing.Point(31, 323);
            this.bnuevo_Click.Name = "bnuevo_Click";
            this.bnuevo_Click.Size = new System.Drawing.Size(85, 43);
            this.bnuevo_Click.TabIndex = 30;
            this.bnuevo_Click.Text = "NUEVO";
            this.bnuevo_Click.UseVisualStyleBackColor = false;
            this.bnuevo_Click.Click += new System.EventHandler(this.bnuevo_Click_Click);
            // 
            // tusuariosBindingSource2
            // 
            this.tusuariosBindingSource2.DataMember = "tusuarios";
            this.tusuariosBindingSource2.DataSource = this.sistemaDataSet;
            // 
            // tusuariosBindingSource3
            // 
            this.tusuariosBindingSource3.DataMember = "tusuarios";
            this.tusuariosBindingSource3.DataSource = this.sistemaDataSet;
            // 
            // bmmmenu
            // 
            this.bmmmenu.BackColor = System.Drawing.Color.Gold;
            this.bmmmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bmmmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmmmenu.Location = new System.Drawing.Point(22, 124);
            this.bmmmenu.Name = "bmmmenu";
            this.bmmmenu.Size = new System.Drawing.Size(67, 36);
            this.bmmmenu.TabIndex = 31;
            this.bmmmenu.Text = "MENU";
            this.bmmmenu.UseVisualStyleBackColor = false;
            this.bmmmenu.Click += new System.EventHandler(this.bmmmenu_Click);
            // 
            // fusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(481, 458);
            this.Controls.Add(this.bmmmenu);
            this.Controls.Add(this.bnuevo_Click);
            this.Controls.Add(this.bprimero_Click);
            this.Controls.Add(this.bactualizar_Click);
            this.Controls.Add(this.bguardar_Click);
            this.Controls.Add(this.bsalir_Click);
            this.Controls.Add(this.bmodificar_Click);
            this.Controls.Add(this.beliminar_Click);
            this.Controls.Add(this.bultimo_Click);
            this.Controls.Add(this.bsiguiente_Click);
            this.Controls.Add(this.banterior_Click);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fusuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESO DE USUARIO";
            this.Load += new System.EventHandler(this.fusuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuariosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuariosBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lstnivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button banterior_Click;
        private System.Windows.Forms.Button bsiguiente_Click;
        private System.Windows.Forms.Button bultimo_Click;
        private System.Windows.Forms.Button beliminar_Click;
        private System.Windows.Forms.Button bmodificar_Click;
        private System.Windows.Forms.Button bsalir_Click;
        private System.Windows.Forms.Button bguardar_Click;
        private System.Windows.Forms.Button bactualizar_Click;
        private sistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource tusuariosBindingSource;
        private sistemaDataSetTableAdapters.tusuariosTableAdapter tusuariosTableAdapter;
        private System.Windows.Forms.BindingSource tusuariosBindingSource1;
        private System.Windows.Forms.Button bprimero_Click;
        private System.Windows.Forms.Button bnuevo_Click;
        private System.Windows.Forms.BindingSource tusuariosBindingSource2;
        private System.Windows.Forms.BindingSource tusuariosBindingSource3;
        private System.Windows.Forms.Button bmmmenu;
    }
}