﻿namespace Proyecto_de_Acceso_a_Base_de_Datos_Access
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
            this.bentrar_access_Click = new System.Windows.Forms.Button();
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
            // bentrar_access_Click
            // 
            this.bentrar_access_Click.Location = new System.Drawing.Point(12, 165);
            this.bentrar_access_Click.Name = "bentrar_access_Click";
            this.bentrar_access_Click.Size = new System.Drawing.Size(85, 33);
            this.bentrar_access_Click.TabIndex = 1;
            this.bentrar_access_Click.Text = "ACCESS";
            this.bentrar_access_Click.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 244);
            this.Controls.Add(this.bentrar_access_Click);
            this.Controls.Add(this.bentrar_sqlserver_Click);
            this.Name = "login";
            this.Text = "LOGIN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bentrar_sqlserver_Click;
        private System.Windows.Forms.Button bentrar_access_Click;
    }
}