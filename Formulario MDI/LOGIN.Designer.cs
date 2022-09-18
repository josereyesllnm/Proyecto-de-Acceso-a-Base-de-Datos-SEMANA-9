
namespace Formulario_MDI
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bentrar_access_Click = new System.Windows.Forms.Button();
            this.bentrar_sqlserver_Click = new System.Windows.Forms.Button();
            this.btnentrarusuario_accesss = new System.Windows.Forms.Button();
            this.btnentrarusuario_sqlserver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(199, 93);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(173, 20);
            this.txtusuario.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "USUARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "CLAVE:";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(199, 139);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(173, 20);
            this.txtclave.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "INICIAR SESION";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(384, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Gold;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(364, 225);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(95, 33);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "LOGIN";
            // 
            // bentrar_access_Click
            // 
            this.bentrar_access_Click.BackColor = System.Drawing.Color.Gold;
            this.bentrar_access_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bentrar_access_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bentrar_access_Click.Location = new System.Drawing.Point(12, 49);
            this.bentrar_access_Click.Name = "bentrar_access_Click";
            this.bentrar_access_Click.Size = new System.Drawing.Size(95, 33);
            this.bentrar_access_Click.TabIndex = 18;
            this.bentrar_access_Click.Text = "ACCESS";
            this.bentrar_access_Click.UseVisualStyleBackColor = false;
            // 
            // bentrar_sqlserver_Click
            // 
            this.bentrar_sqlserver_Click.BackColor = System.Drawing.Color.Gold;
            this.bentrar_sqlserver_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bentrar_sqlserver_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bentrar_sqlserver_Click.Location = new System.Drawing.Point(12, 96);
            this.bentrar_sqlserver_Click.Name = "bentrar_sqlserver_Click";
            this.bentrar_sqlserver_Click.Size = new System.Drawing.Size(95, 33);
            this.bentrar_sqlserver_Click.TabIndex = 19;
            this.bentrar_sqlserver_Click.Text = "SQLSERVER";
            this.bentrar_sqlserver_Click.UseVisualStyleBackColor = false;
            // 
            // btnentrarusuario_accesss
            // 
            this.btnentrarusuario_accesss.BackColor = System.Drawing.Color.Gold;
            this.btnentrarusuario_accesss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnentrarusuario_accesss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrarusuario_accesss.Location = new System.Drawing.Point(12, 210);
            this.btnentrarusuario_accesss.Name = "btnentrarusuario_accesss";
            this.btnentrarusuario_accesss.Size = new System.Drawing.Size(95, 48);
            this.btnentrarusuario_accesss.TabIndex = 20;
            this.btnentrarusuario_accesss.Text = "INGRESO DE USUARIO ACCESS";
            this.btnentrarusuario_accesss.UseVisualStyleBackColor = false;
            // 
            // btnentrarusuario_sqlserver
            // 
            this.btnentrarusuario_sqlserver.BackColor = System.Drawing.Color.Gold;
            this.btnentrarusuario_sqlserver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnentrarusuario_sqlserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrarusuario_sqlserver.Location = new System.Drawing.Point(12, 142);
            this.btnentrarusuario_sqlserver.Name = "btnentrarusuario_sqlserver";
            this.btnentrarusuario_sqlserver.Size = new System.Drawing.Size(95, 50);
            this.btnentrarusuario_sqlserver.TabIndex = 21;
            this.btnentrarusuario_sqlserver.Text = "INGRESO DE USUARIO SQLSERVER";
            this.btnentrarusuario_sqlserver.UseVisualStyleBackColor = false;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(471, 270);
            this.Controls.Add(this.btnentrarusuario_sqlserver);
            this.Controls.Add(this.btnentrarusuario_accesss);
            this.Controls.Add(this.bentrar_sqlserver_Click);
            this.Controls.Add(this.bentrar_access_Click);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bentrar_access_Click;
        private System.Windows.Forms.Button bentrar_sqlserver_Click;
        private System.Windows.Forms.Button btnentrarusuario_accesss;
        private System.Windows.Forms.Button btnentrarusuario_sqlserver;
    }
}