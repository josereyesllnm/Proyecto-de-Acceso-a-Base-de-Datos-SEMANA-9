
namespace Formulario_MDI
{
    partial class CLIENTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLIENTES));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NUEVO_23 = new System.Windows.Forms.Button();
            this.GUARDAR_23 = new System.Windows.Forms.Button();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bbtnbuscar = new System.Windows.Forms.Button();
            this.txttbuscar = new System.Windows.Forms.TextBox();
            this.ELIMINAR_23 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BTNACTUALIZAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(396, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLIENTES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(1065, 548);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 60);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(396, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(594, 284);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NUEVO_23
            // 
            this.NUEVO_23.BackColor = System.Drawing.Color.LimeGreen;
            this.NUEVO_23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NUEVO_23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUEVO_23.Location = new System.Drawing.Point(396, 233);
            this.NUEVO_23.Name = "NUEVO_23";
            this.NUEVO_23.Size = new System.Drawing.Size(95, 37);
            this.NUEVO_23.TabIndex = 17;
            this.NUEVO_23.Text = "NUEVO";
            this.NUEVO_23.UseVisualStyleBackColor = false;
            this.NUEVO_23.Click += new System.EventHandler(this.NUEVO_23_Click);
            // 
            // GUARDAR_23
            // 
            this.GUARDAR_23.BackColor = System.Drawing.Color.LimeGreen;
            this.GUARDAR_23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GUARDAR_23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUARDAR_23.Location = new System.Drawing.Point(520, 233);
            this.GUARDAR_23.Name = "GUARDAR_23";
            this.GUARDAR_23.Size = new System.Drawing.Size(95, 37);
            this.GUARDAR_23.TabIndex = 18;
            this.GUARDAR_23.Text = "GUARDAR";
            this.GUARDAR_23.UseVisualStyleBackColor = false;
            this.GUARDAR_23.Click += new System.EventHandler(this.GUARDAR_23_Click);
            // 
            // txtnombre1
            // 
            this.txtnombre1.Location = new System.Drawing.Point(622, 73);
            this.txtnombre1.Multiline = true;
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Size = new System.Drawing.Size(179, 23);
            this.txtnombre1.TabIndex = 20;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(622, 113);
            this.txtapellido.Multiline = true;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(179, 23);
            this.txtapellido.TabIndex = 21;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(622, 161);
            this.txtcelular.Multiline = true;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(179, 23);
            this.txtcelular.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Celular:";
            // 
            // bbtnbuscar
            // 
            this.bbtnbuscar.BackColor = System.Drawing.Color.LimeGreen;
            this.bbtnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bbtnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnbuscar.Location = new System.Drawing.Point(992, 151);
            this.bbtnbuscar.Name = "bbtnbuscar";
            this.bbtnbuscar.Size = new System.Drawing.Size(82, 33);
            this.bbtnbuscar.TabIndex = 26;
            this.bbtnbuscar.Text = "BUSCAR";
            this.bbtnbuscar.UseVisualStyleBackColor = false;
            this.bbtnbuscar.Click += new System.EventHandler(this.txttbuscar_Click);
            // 
            // txttbuscar
            // 
            this.txttbuscar.Location = new System.Drawing.Point(924, 113);
            this.txttbuscar.Multiline = true;
            this.txttbuscar.Name = "txttbuscar";
            this.txttbuscar.Size = new System.Drawing.Size(202, 25);
            this.txttbuscar.TabIndex = 27;
            // 
            // ELIMINAR_23
            // 
            this.ELIMINAR_23.BackColor = System.Drawing.Color.LimeGreen;
            this.ELIMINAR_23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ELIMINAR_23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELIMINAR_23.Location = new System.Drawing.Point(895, 234);
            this.ELIMINAR_23.Name = "ELIMINAR_23";
            this.ELIMINAR_23.Size = new System.Drawing.Size(95, 37);
            this.ELIMINAR_23.TabIndex = 28;
            this.ELIMINAR_23.Text = "ELIMINAR";
            this.ELIMINAR_23.UseVisualStyleBackColor = false;
            this.ELIMINAR_23.Click += new System.EventHandler(this.ELIMINAR_23_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 495);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // BTNACTUALIZAR
            // 
            this.BTNACTUALIZAR.BackColor = System.Drawing.Color.LimeGreen;
            this.BTNACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNACTUALIZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACTUALIZAR.Location = new System.Drawing.Point(775, 233);
            this.BTNACTUALIZAR.Name = "BTNACTUALIZAR";
            this.BTNACTUALIZAR.Size = new System.Drawing.Size(95, 37);
            this.BTNACTUALIZAR.TabIndex = 38;
            this.BTNACTUALIZAR.Text = "ACTUALIZAR";
            this.BTNACTUALIZAR.UseVisualStyleBackColor = false;
            this.BTNACTUALIZAR.Click += new System.EventHandler(this.BTNACTUALIZAR_Click);
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.BackColor = System.Drawing.Color.LimeGreen;
            this.BTNMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNMODIFICAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMODIFICAR.Location = new System.Drawing.Point(647, 234);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(95, 36);
            this.BTNMODIFICAR.TabIndex = 39;
            this.BTNMODIFICAR.Text = "MODIFICAR";
            this.BTNMODIFICAR.UseVisualStyleBackColor = false;
            this.BTNMODIFICAR.Click += new System.EventHandler(this.BTNMODIFICAR_Click);
            // 
            // CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1138, 620);
            this.Controls.Add(this.BTNMODIFICAR);
            this.Controls.Add(this.BTNACTUALIZAR);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ELIMINAR_23);
            this.Controls.Add(this.txttbuscar);
            this.Controls.Add(this.bbtnbuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre1);
            this.Controls.Add(this.GUARDAR_23);
            this.Controls.Add(this.NUEVO_23);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CLIENTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPUTERS GUEVARA - REGISTRO DE CLIENTES";
            this.Load += new System.EventHandler(this.CLIENTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button NUEVO_23;
        private System.Windows.Forms.Button GUARDAR_23;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bbtnbuscar;
        private System.Windows.Forms.TextBox txttbuscar;
        private System.Windows.Forms.Button ELIMINAR_23;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BTNACTUALIZAR;
        private System.Windows.Forms.Button BTNMODIFICAR;
    }
}