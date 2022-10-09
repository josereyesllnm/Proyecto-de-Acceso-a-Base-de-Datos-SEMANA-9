
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bbtnbuscar = new System.Windows.Forms.Button();
            this.txttbuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(557, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLIENTES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(673, 531);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 31);
            this.button4.TabIndex = 15;
            this.button4.Text = "VOLVER AL MENU";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(28, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(474, 328);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NUEVO_23
            // 
            this.NUEVO_23.BackColor = System.Drawing.Color.LimeGreen;
            this.NUEVO_23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NUEVO_23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUEVO_23.Location = new System.Drawing.Point(318, 36);
            this.NUEVO_23.Name = "NUEVO_23";
            this.NUEVO_23.Size = new System.Drawing.Size(77, 37);
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
            this.GUARDAR_23.Location = new System.Drawing.Point(318, 106);
            this.GUARDAR_23.Name = "GUARDAR_23";
            this.GUARDAR_23.Size = new System.Drawing.Size(77, 37);
            this.GUARDAR_23.TabIndex = 18;
            this.GUARDAR_23.Text = "GUARDAR";
            this.GUARDAR_23.UseVisualStyleBackColor = false;
            this.GUARDAR_23.Click += new System.EventHandler(this.GUARDAR_23_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(110, 36);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(138, 23);
            this.txtnombre.TabIndex = 20;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(110, 78);
            this.txtapellidos.Multiline = true;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(138, 23);
            this.txtapellidos.TabIndex = 21;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(110, 120);
            this.txtcelular.Multiline = true;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(138, 23);
            this.txtcelular.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 123);
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
            this.bbtnbuscar.Location = new System.Drawing.Point(615, 71);
            this.bbtnbuscar.Name = "bbtnbuscar";
            this.bbtnbuscar.Size = new System.Drawing.Size(82, 33);
            this.bbtnbuscar.TabIndex = 26;
            this.bbtnbuscar.Text = "BUSCAR";
            this.bbtnbuscar.UseVisualStyleBackColor = false;
            this.bbtnbuscar.Click += new System.EventHandler(this.txttbuscar_Click);
            // 
            // txttbuscar
            // 
            this.txttbuscar.Location = new System.Drawing.Point(557, 36);
            this.txttbuscar.Multiline = true;
            this.txttbuscar.Name = "txttbuscar";
            this.txttbuscar.Size = new System.Drawing.Size(202, 25);
            this.txttbuscar.TabIndex = 27;
            // 
            // CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(818, 568);
            this.Controls.Add(this.txttbuscar);
            this.Controls.Add(this.bbtnbuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.GUARDAR_23);
            this.Controls.Add(this.NUEVO_23);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CLIENTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE CLIENTES";
            this.Load += new System.EventHandler(this.CLIENTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bbtnbuscar;
        private System.Windows.Forms.TextBox txttbuscar;
    }
}