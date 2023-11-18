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
            label1 = new Label();
            label2 = new Label();
            btnProducto = new Button();
            btnEmpleado = new Button();
            btnCategoria = new Button();
            btnProveedor = new Button();
            btnCerrarSesion = new Button();
            btnPedido = new Button();
            panel1 = new Panel();
            btnCliente = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(177, 26);
            label1.TabIndex = 2;
            label1.Text = "Espresso Esencial ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 63);
            label2.Name = "label2";
            label2.Size = new Size(240, 21);
            label2.TabIndex = 3;
            label2.Text = "| Seleccione la opcion a gestionar";
            // 
            // btnProducto
            // 
            btnProducto.BackColor = Color.White;
            btnProducto.BackgroundImage = Properties.Resources.producto;
            btnProducto.BackgroundImageLayout = ImageLayout.Stretch;
            btnProducto.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducto.ForeColor = Color.Black;
            btnProducto.Location = new Point(615, 110);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(250, 250);
            btnProducto.TabIndex = 3;
            btnProducto.Text = "Producto";
            btnProducto.TextAlign = ContentAlignment.BottomCenter;
            btnProducto.UseVisualStyleBackColor = false;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackColor = Color.White;
            btnEmpleado.BackgroundImage = Properties.Resources.empleado;
            btnEmpleado.BackgroundImageLayout = ImageLayout.Stretch;
            btnEmpleado.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpleado.ForeColor = Color.Black;
            btnEmpleado.Location = new Point(905, 110);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(250, 250);
            btnEmpleado.TabIndex = 4;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.TextAlign = ContentAlignment.BottomCenter;
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.BackColor = Color.White;
            btnCategoria.BackgroundImage = Properties.Resources.categoria;
            btnCategoria.BackgroundImageLayout = ImageLayout.Stretch;
            btnCategoria.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategoria.ForeColor = Color.Black;
            btnCategoria.Location = new Point(45, 374);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(250, 250);
            btnCategoria.TabIndex = 5;
            btnCategoria.Text = "Categoria";
            btnCategoria.TextAlign = ContentAlignment.BottomCenter;
            btnCategoria.UseVisualStyleBackColor = false;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = Color.White;
            btnProveedor.BackgroundImage = Properties.Resources.proveedor;
            btnProveedor.BackgroundImageLayout = ImageLayout.Stretch;
            btnProveedor.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedor.ForeColor = Color.Black;
            btnProveedor.Location = new Point(330, 374);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(250, 250);
            btnProveedor.TabIndex = 6;
            btnProveedor.Text = "Proveedor";
            btnProveedor.TextAlign = ContentAlignment.BottomCenter;
            btnProveedor.UseVisualStyleBackColor = false;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.White;
            btnCerrarSesion.ForeColor = SystemColors.ControlText;
            btnCerrarSesion.Location = new Point(1057, 14);
            btnCerrarSesion.Margin = new Padding(4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(115, 32);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.White;
            btnPedido.BackgroundImage = Properties.Resources.pedido;
            btnPedido.BackgroundImageLayout = ImageLayout.Stretch;
            btnPedido.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedido.ForeColor = Color.Black;
            btnPedido.Location = new Point(45, 110);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(250, 250);
            btnPedido.TabIndex = 1;
            btnPedido.Text = "Pedido";
            btnPedido.TextAlign = ContentAlignment.BottomCenter;
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 96);
            panel1.TabIndex = 12;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.White;
            btnCliente.BackgroundImage = Properties.Resources.cliente;
            btnCliente.BackgroundImageLayout = ImageLayout.Stretch;
            btnCliente.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCliente.ForeColor = Color.Black;
            btnCliente.Location = new Point(330, 110);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(250, 250);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Cliente";
            btnCliente.TextAlign = ContentAlignment.BottomCenter;
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click_1;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 681);
            ControlBox = false;
            Controls.Add(btnCliente);
            Controls.Add(panel1);
            Controls.Add(btnPedido);
            Controls.Add(btnProveedor);
            Controls.Add(btnCategoria);
            Controls.Add(btnEmpleado);
            Controls.Add(btnProducto);
            Cursor = Cursors.Hand;
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkBlue;
            Margin = new Padding(4);
            Name = "main";
            Text = "Espresso Esencial - Principal";
            Load += main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnProducto;
        private Button btnEmpleado;
        private Button btnCategoria;
        private Button btnProveedor;
        private Button btnCerrarSesion;
        private Button btnPedido;
        private Panel panel1;
        private Button btnCliente;
    }
}