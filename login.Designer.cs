namespace Proyecto_de_Acceso_a_Base_de_Datos_Access
{
    partial class login
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
            this.bentrar_sqlserver_Click = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bentrar_sqlserver_Click
            // 
            this.bentrar_sqlserver_Click.Location = new System.Drawing.Point(12, 204);
            this.bentrar_sqlserver_Click.Name = "bentrar_sqlserver_Click";
            this.bentrar_sqlserver_Click.Size = new System.Drawing.Size(85, 33);
            this.bentrar_sqlserver_Click.TabIndex = 0;
            this.bentrar_sqlserver_Click.Text = "SQLSERVER";
            this.bentrar_sqlserver_Click.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 244);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bentrar_sqlserver_Click);
            this.Name = "login";
            this.Text = "LOGIN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bentrar_sqlserver_Click;
        private System.Windows.Forms.Button button2;
    }
}