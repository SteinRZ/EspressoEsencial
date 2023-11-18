namespace Espresso_Esencial
{
    partial class main
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
            btnCerrar = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(920, 13);
            btnCerrar.Margin = new Padding(4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(96, 32);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 26);
            label1.TabIndex = 2;
            label1.Text = "Espresso Esencial ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(240, 21);
            label2.TabIndex = 3;
            label2.Text = "| Seleccione la opcion a gestionar";
            // 
            // button1
            // 
            button1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(80, 90);
            button1.Name = "button1";
            button1.Size = new Size(250, 250);
            button1.TabIndex = 4;
            button1.Text = "Pedido";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(405, 90);
            button2.Name = "button2";
            button2.Size = new Size(250, 250);
            button2.TabIndex = 5;
            button2.Text = "Cliente";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(730, 90);
            button3.Name = "button3";
            button3.Size = new Size(250, 250);
            button3.TabIndex = 6;
            button3.Text = "Producto";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(80, 360);
            button4.Name = "button4";
            button4.Size = new Size(250, 250);
            button4.TabIndex = 7;
            button4.Text = "Empleado";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(405, 360);
            button5.Name = "button5";
            button5.Size = new Size(250, 250);
            button5.TabIndex = 8;
            button5.Text = "Categoria";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(730, 360);
            button6.Name = "button6";
            button6.Size = new Size(250, 250);
            button6.TabIndex = 9;
            button6.Text = "Proveedor";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(797, 13);
            btnCerrarSesion.Margin = new Padding(4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(115, 32);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            ControlBox = false;
            Controls.Add(btnCerrarSesion);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "main";
            Text = "Espresso Esencial - Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnCerrarSesion;
    }
}