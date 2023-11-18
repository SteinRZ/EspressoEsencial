namespace Espresso_Esencial
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
            btnCerrar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txtContraseña = new TextBox();
            label4 = new Label();
            txtCorreoElectronico = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1075, 13);
            btnCerrar.Margin = new Padding(4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(96, 32);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(712, 681);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCorreoElectronico);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEntrar);
            panel1.Location = new Point(729, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 617);
            panel1.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(19, 325);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(407, 31);
            txtContraseña.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 300);
            label4.Name = "label4";
            label4.Size = new Size(119, 26);
            label4.TabIndex = 5;
            label4.Text = "Contraseña:";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreoElectronico.Location = new Point(19, 255);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(407, 31);
            txtCorreoElectronico.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 230);
            label3.Name = "label3";
            label3.Size = new Size(180, 26);
            label3.TabIndex = 3;
            label3.Text = "Correo electronico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 195);
            label2.Name = "label2";
            label2.Size = new Size(324, 21);
            label2.TabIndex = 2;
            label2.Text = "| Ingrese sus credenciales de manera correcta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 130);
            label1.Name = "label1";
            label1.Size = new Size(407, 37);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido a Espresso Esencial";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(182, 385);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(96, 33);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 681);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrar);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "login";
            Text = "Espresso Esencial - Login";
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
        private TextBox txtCorreoElectronico;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}