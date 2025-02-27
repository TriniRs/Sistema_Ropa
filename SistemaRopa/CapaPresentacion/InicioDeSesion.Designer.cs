﻿namespace CapaPresentacion
{
    partial class InicioDeSesion
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
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.labelLineContrasena = new System.Windows.Forms.Label();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.labelLineDocumento = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelSubTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSalir.Location = new System.Drawing.Point(20, 286);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(121, 35);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresar.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonIngresar.Location = new System.Drawing.Point(150, 287);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(120, 34);
            this.buttonIngresar.TabIndex = 3;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelContrasena.Location = new System.Drawing.Point(103, 217);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(71, 19);
            this.labelContrasena.TabIndex = 31;
            this.labelContrasena.Text = "Contraseña";
            // 
            // textBoxClave
            // 
            this.textBoxClave.BackColor = System.Drawing.Color.DimGray;
            this.textBoxClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClave.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClave.ForeColor = System.Drawing.Color.White;
            this.textBoxClave.Location = new System.Drawing.Point(20, 239);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(250, 20);
            this.textBoxClave.TabIndex = 2;
            this.textBoxClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxClave_KeyDown);
            // 
            // labelLineContrasena
            // 
            this.labelLineContrasena.BackColor = System.Drawing.Color.White;
            this.labelLineContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineContrasena.Location = new System.Drawing.Point(20, 262);
            this.labelLineContrasena.Name = "labelLineContrasena";
            this.labelLineContrasena.Size = new System.Drawing.Size(250, 1);
            this.labelLineContrasena.TabIndex = 29;
            this.labelLineContrasena.Text = "label2";
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelDocumento.Location = new System.Drawing.Point(106, 145);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(68, 19);
            this.labelDocumento.TabIndex = 28;
            this.labelDocumento.Text = "Documento";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.BackColor = System.Drawing.Color.DimGray;
            this.textBoxDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDocumento.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDocumento.ForeColor = System.Drawing.Color.White;
            this.textBoxDocumento.Location = new System.Drawing.Point(20, 167);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(250, 20);
            this.textBoxDocumento.TabIndex = 1;
            this.textBoxDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDocumento_KeyDown);
            this.textBoxDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDocumento_KeyPress);
            // 
            // labelLineDocumento
            // 
            this.labelLineDocumento.BackColor = System.Drawing.Color.White;
            this.labelLineDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineDocumento.Location = new System.Drawing.Point(20, 190);
            this.labelLineDocumento.Name = "labelLineDocumento";
            this.labelLineDocumento.Size = new System.Drawing.Size(250, 1);
            this.labelLineDocumento.TabIndex = 26;
            this.labelLineDocumento.Text = "label2";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitulo.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelTitulo.Location = new System.Drawing.Point(16, 19);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(256, 68);
            this.labelTitulo.TabIndex = 25;
            this.labelTitulo.Text = "Sistema Ropa";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // labelSubTitulo
            // 
            this.labelSubTitulo.AutoSize = true;
            this.labelSubTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelSubTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitulo.ForeColor = System.Drawing.Color.White;
            this.labelSubTitulo.Location = new System.Drawing.Point(88, 87);
            this.labelSubTitulo.Name = "labelSubTitulo";
            this.labelSubTitulo.Size = new System.Drawing.Size(107, 23);
            this.labelSubTitulo.TabIndex = 33;
            this.labelSubTitulo.Text = "Inicio de sesión";
            this.labelSubTitulo.Click += new System.EventHandler(this.labelSubTitulo_Click);
            // 
            // InicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 391);
            this.Controls.Add(this.labelSubTitulo);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.labelContrasena);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.labelLineContrasena);
            this.Controls.Add(this.labelDocumento);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.labelLineDocumento);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 430);
            this.MinimumSize = new System.Drawing.Size(300, 430);
            this.Name = "InicioDeSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Label labelLineContrasena;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label labelLineDocumento;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubTitulo;
    }
}