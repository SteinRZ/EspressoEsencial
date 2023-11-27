namespace Espresso_Esencial
{
    partial class client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client));
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            lblEmpleado = new Label();
            lnkProveedor = new LinkLabel();
            lnkCategoria = new LinkLabel();
            lnkEmpleado = new LinkLabel();
            lnkProducto = new LinkLabel();
            lnkPedido = new LinkLabel();
            lnkInicio = new LinkLabel();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            chkEstudiante = new CheckBox();
            btnClienteAgregar = new Button();
            txtClienteCorreo = new TextBox();
            txtClienteTelefono = new TextBox();
            txtClienteNombre = new TextBox();
            txtClienteApellidoMaterno = new TextBox();
            txtClienteApellidoPaterno = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            tabPage2 = new TabPage();
            btnClienteConsultaHistorial = new Button();
            btnClienteEliminar = new Button();
            dgvConsultaCliente = new DataGridView();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 4;
            label1.Text = "Cliente";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblEmpleado);
            panel1.Controls.Add(lnkProveedor);
            panel1.Controls.Add(lnkCategoria);
            panel1.Controls.Add(lnkEmpleado);
            panel1.Controls.Add(lnkProducto);
            panel1.Controls.Add(lnkPedido);
            panel1.Controls.Add(lnkInicio);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 683);
            panel1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 2);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 9;
            label7.Text = "Empleado:";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpleado.ForeColor = Color.White;
            lblEmpleado.Location = new Point(0, 25);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(140, 21);
            lblEmpleado.TabIndex = 8;
            lblEmpleado.Text = "nombre_empleado";
            // 
            // lnkProveedor
            // 
            lnkProveedor.ActiveLinkColor = Color.Black;
            lnkProveedor.AutoSize = true;
            lnkProveedor.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkProveedor.LinkColor = Color.White;
            lnkProveedor.Location = new Point(13, 399);
            lnkProveedor.Name = "lnkProveedor";
            lnkProveedor.Size = new Size(103, 26);
            lnkProveedor.TabIndex = 5;
            lnkProveedor.TabStop = true;
            lnkProveedor.Text = "Proveedor";
            lnkProveedor.LinkClicked += lnkProveedor_LinkClicked;
            // 
            // lnkCategoria
            // 
            lnkCategoria.ActiveLinkColor = Color.Black;
            lnkCategoria.AutoSize = true;
            lnkCategoria.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkCategoria.LinkColor = Color.White;
            lnkCategoria.Location = new Point(13, 350);
            lnkCategoria.Name = "lnkCategoria";
            lnkCategoria.Size = new Size(98, 26);
            lnkCategoria.TabIndex = 4;
            lnkCategoria.TabStop = true;
            lnkCategoria.Text = "Categoria";
            lnkCategoria.LinkClicked += lnkCategoria_LinkClicked;
            // 
            // lnkEmpleado
            // 
            lnkEmpleado.ActiveLinkColor = Color.Black;
            lnkEmpleado.AutoSize = true;
            lnkEmpleado.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkEmpleado.LinkColor = Color.White;
            lnkEmpleado.Location = new Point(13, 301);
            lnkEmpleado.Name = "lnkEmpleado";
            lnkEmpleado.Size = new Size(101, 26);
            lnkEmpleado.TabIndex = 3;
            lnkEmpleado.TabStop = true;
            lnkEmpleado.Text = "Empleado";
            lnkEmpleado.LinkClicked += lnkEmpleado_LinkClicked;
            // 
            // lnkProducto
            // 
            lnkProducto.ActiveLinkColor = Color.Black;
            lnkProducto.AutoSize = true;
            lnkProducto.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkProducto.LinkColor = Color.White;
            lnkProducto.Location = new Point(13, 257);
            lnkProducto.Name = "lnkProducto";
            lnkProducto.Size = new Size(93, 26);
            lnkProducto.TabIndex = 2;
            lnkProducto.TabStop = true;
            lnkProducto.Text = "Producto";
            lnkProducto.LinkClicked += lnkProducto_LinkClicked;
            // 
            // lnkPedido
            // 
            lnkPedido.ActiveLinkColor = Color.Black;
            lnkPedido.AutoSize = true;
            lnkPedido.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkPedido.LinkColor = Color.White;
            lnkPedido.Location = new Point(13, 213);
            lnkPedido.Name = "lnkPedido";
            lnkPedido.Size = new Size(74, 26);
            lnkPedido.TabIndex = 1;
            lnkPedido.TabStop = true;
            lnkPedido.Text = "Pedido";
            lnkPedido.LinkClicked += lnkPedido_LinkClicked;
            // 
            // lnkInicio
            // 
            lnkInicio.ActiveLinkColor = Color.Black;
            lnkInicio.AutoSize = true;
            lnkInicio.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkInicio.LinkColor = Color.White;
            lnkInicio.Location = new Point(13, 171);
            lnkInicio.Name = "lnkInicio";
            lnkInicio.Size = new Size(60, 26);
            lnkInicio.TabIndex = 0;
            lnkInicio.TabStop = true;
            lnkInicio.Text = "Inicio";
            lnkInicio.LinkClicked += lnkInicio_LinkClicked;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 35);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 4);
            label3.Name = "label3";
            label3.Size = new Size(116, 26);
            label3.TabIndex = 0;
            label3.Text = "Navegación";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(215, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(970, 81);
            panel3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(739, 60);
            label2.Name = "label2";
            label2.Size = new Size(227, 21);
            label2.TabIndex = 5;
            label2.Text = "Gestion del apartado de cliente.";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(215, 83);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(970, 599);
            tabControl1.TabIndex = 11;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chkEstudiante);
            tabPage1.Controls.Add(btnClienteAgregar);
            tabPage1.Controls.Add(txtClienteCorreo);
            tabPage1.Controls.Add(txtClienteTelefono);
            tabPage1.Controls.Add(txtClienteNombre);
            tabPage1.Controls.Add(txtClienteApellidoMaterno);
            tabPage1.Controls.Add(txtClienteApellidoPaterno);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label8);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(962, 565);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(503, 301);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(138, 25);
            chkEstudiante.TabIndex = 27;
            chkEstudiante.Text = "¿Es estudiante?";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnClienteAgregar
            // 
            btnClienteAgregar.Cursor = Cursors.Hand;
            btnClienteAgregar.Location = new Point(819, 522);
            btnClienteAgregar.Name = "btnClienteAgregar";
            btnClienteAgregar.Size = new Size(134, 34);
            btnClienteAgregar.TabIndex = 25;
            btnClienteAgregar.Text = "Agregar cliente";
            btnClienteAgregar.UseVisualStyleBackColor = true;
            btnClienteAgregar.Click += btnClienteAgregar_Click;
            // 
            // txtClienteCorreo
            // 
            txtClienteCorreo.Location = new Point(10, 300);
            txtClienteCorreo.Name = "txtClienteCorreo";
            txtClienteCorreo.Size = new Size(449, 26);
            txtClienteCorreo.TabIndex = 23;
            // 
            // txtClienteTelefono
            // 
            txtClienteTelefono.Location = new Point(503, 209);
            txtClienteTelefono.Name = "txtClienteTelefono";
            txtClienteTelefono.Size = new Size(450, 26);
            txtClienteTelefono.TabIndex = 22;
            // 
            // txtClienteNombre
            // 
            txtClienteNombre.Location = new Point(10, 209);
            txtClienteNombre.Name = "txtClienteNombre";
            txtClienteNombre.Size = new Size(449, 26);
            txtClienteNombre.TabIndex = 21;
            // 
            // txtClienteApellidoMaterno
            // 
            txtClienteApellidoMaterno.Location = new Point(503, 123);
            txtClienteApellidoMaterno.Name = "txtClienteApellidoMaterno";
            txtClienteApellidoMaterno.Size = new Size(450, 26);
            txtClienteApellidoMaterno.TabIndex = 20;
            // 
            // txtClienteApellidoPaterno
            // 
            txtClienteApellidoPaterno.Location = new Point(9, 123);
            txtClienteApellidoPaterno.Name = "txtClienteApellidoPaterno";
            txtClienteApellidoPaterno.Size = new Size(450, 26);
            txtClienteApellidoPaterno.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 276);
            label11.Name = "label11";
            label11.Size = new Size(134, 21);
            label11.TabIndex = 17;
            label11.Text = "Correo electronico:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(503, 185);
            label10.Name = "label10";
            label10.Size = new Size(72, 21);
            label10.TabIndex = 16;
            label10.Text = "Telefono:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 185);
            label9.Name = "label9";
            label9.Size = new Size(85, 21);
            label9.TabIndex = 15;
            label9.Text = "Nombre(s):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(503, 99);
            label6.Name = "label6";
            label6.Size = new Size(132, 21);
            label6.TabIndex = 14;
            label6.Text = "Apellido materno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 99);
            label5.Name = "label5";
            label5.Size = new Size(127, 21);
            label5.TabIndex = 13;
            label5.Text = "Apellido paterno:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(9, 7);
            label8.Name = "label8";
            label8.Size = new Size(148, 26);
            label8.TabIndex = 12;
            label8.Text = "Agregar cliente";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnClienteConsultaHistorial);
            tabPage2.Controls.Add(btnClienteEliminar);
            tabPage2.Controls.Add(dgvConsultaCliente);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(962, 565);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClienteConsultaHistorial
            // 
            btnClienteConsultaHistorial.Cursor = Cursors.Hand;
            btnClienteConsultaHistorial.Location = new Point(786, 42);
            btnClienteConsultaHistorial.Name = "btnClienteConsultaHistorial";
            btnClienteConsultaHistorial.Size = new Size(165, 40);
            btnClienteConsultaHistorial.TabIndex = 18;
            btnClienteConsultaHistorial.Text = "Consultar historial";
            btnClienteConsultaHistorial.UseVisualStyleBackColor = true;
            // 
            // btnClienteEliminar
            // 
            btnClienteEliminar.Cursor = Cursors.Hand;
            btnClienteEliminar.Location = new Point(788, 88);
            btnClienteEliminar.Name = "btnClienteEliminar";
            btnClienteEliminar.Size = new Size(165, 40);
            btnClienteEliminar.TabIndex = 17;
            btnClienteEliminar.Text = "Eliminar";
            btnClienteEliminar.UseVisualStyleBackColor = true;
            btnClienteEliminar.Click += btnClienteEliminar_Click;
            // 
            // dgvConsultaCliente
            // 
            dgvConsultaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaCliente.Location = new Point(6, 42);
            dgvConsultaCliente.Name = "dgvConsultaCliente";
            dgvConsultaCliente.RowTemplate.Height = 25;
            dgvConsultaCliente.Size = new Size(774, 520);
            dgvConsultaCliente.TabIndex = 14;
            dgvConsultaCliente.CellValidating += dgvConsultaCliente_CellValidating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 7);
            label4.Name = "label4";
            label4.Size = new Size(190, 26);
            label4.TabIndex = 13;
            label4.Text = "Clientes registrados";
            // 
            // client
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 681);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(tabControl1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "client";
            Text = "Espresso Esencial - Cliente";
            Load += client_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private LinkLabel lnkProveedor;
        private LinkLabel lnkCategoria;
        private LinkLabel lnkEmpleado;
        private LinkLabel lnkProducto;
        private LinkLabel lnkPedido;
        private LinkLabel lnkInicio;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label7;
        private Label lblEmpleado;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label9;
        private Label label6;
        private TextBox txtClienteApellidoPaterno;
        private Label label11;
        private Label label10;
        private TextBox txtClienteCorreo;
        private TextBox txtClienteTelefono;
        private TextBox txtClienteNombre;
        private TextBox txtClienteApellidoMaterno;
        private Button btnClienteAgregar;
        private DataGridView dgvConsultaCliente;
        private Button btnClienteEliminar;
        private Button btnClienteConsultaHistorial;
        private CheckBox chkEstudiante;
    }
}