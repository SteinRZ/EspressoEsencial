﻿namespace Espresso_Esencial
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            btnCerrar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txtContraseña = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEntrar = new Button();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(365, 13);
            btnCerrar.Margin = new Padding(4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(96, 32);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(712, 681);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEntrar);
            panel1.Location = new Point(710, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 681);
            panel1.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(30, 360);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(407, 31);
            txtContraseña.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 335);
            label4.Name = "label4";
            label4.Size = new Size(114, 26);
            label4.TabIndex = 5;
            label4.Text = "Contraseña";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(30, 290);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(407, 31);
            txtUsername.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 265);
            label3.Name = "label3";
            label3.Size = new Size(182, 26);
            label3.TabIndex = 3;
            label3.Text = "Nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 230);
            label2.Name = "label2";
            label2.Size = new Size(324, 21);
            label2.TabIndex = 2;
            label2.Text = "| Ingrese sus credenciales de manera correcta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 165);
            label1.Name = "label1";
            label1.Size = new Size(407, 37);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido a Espresso Esencial";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.White;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Location = new Point(193, 420);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(96, 33);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Coral;
            lblError.Location = new Point(30, 394);
            lblError.Name = "lblError";
            lblError.Size = new Size(58, 18);
            lblError.TabIndex = 7;
            lblError.Text = "ERROR";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1184, 681);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "login";
            Text = "Espresso Esencial - Inicio de sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnEntrar;
        private TextBox txtContraseña;
        private Label label4;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblError;
    }
}