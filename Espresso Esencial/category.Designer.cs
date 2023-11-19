namespace Espresso_Esencial
{
    partial class category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(category));
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            lblEmpleado = new Label();
            lnkIngrediente = new LinkLabel();
            lnkProveedor = new LinkLabel();
            lnkEmpleado = new LinkLabel();
            lnkProducto = new LinkLabel();
            lnkCliente = new LinkLabel();
            lnkPedido = new LinkLabel();
            lnkInicio = new LinkLabel();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            gpxCategoriaAgregar = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            txtCategoriaNombre = new TextBox();
            txtCategoriaDescripcion = new TextBox();
            btnCategoriaCancelar = new Button();
            btnCategoriaAgregar = new Button();
            gpxCategoriaConsulta = new GroupBox();
            dgvCategoriaConsultar = new DataGridView();
            btnClienteEliminar = new Button();
            btnClienteModificar = new Button();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            gpxCategoriaAgregar.SuspendLayout();
            gpxCategoriaConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriaConsultar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 4;
            label1.Text = "Categoria";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblEmpleado);
            panel1.Controls.Add(lnkIngrediente);
            panel1.Controls.Add(lnkProveedor);
            panel1.Controls.Add(lnkEmpleado);
            panel1.Controls.Add(lnkProducto);
            panel1.Controls.Add(lnkCliente);
            panel1.Controls.Add(lnkPedido);
            panel1.Controls.Add(lnkInicio);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 683);
            panel1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 2);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 18;
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
            lblEmpleado.TabIndex = 17;
            lblEmpleado.Text = "nombre_empleado";
            // 
            // lnkIngrediente
            // 
            lnkIngrediente.ActiveLinkColor = Color.Black;
            lnkIngrediente.AutoSize = true;
            lnkIngrediente.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkIngrediente.LinkColor = Color.White;
            lnkIngrediente.Location = new Point(13, 446);
            lnkIngrediente.Name = "lnkIngrediente";
            lnkIngrediente.Size = new Size(114, 26);
            lnkIngrediente.TabIndex = 16;
            lnkIngrediente.TabStop = true;
            lnkIngrediente.Text = "Ingrediente";
            lnkIngrediente.LinkClicked += lnkIngrediente_LinkClicked;
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
            // lnkEmpleado
            // 
            lnkEmpleado.ActiveLinkColor = Color.Black;
            lnkEmpleado.AutoSize = true;
            lnkEmpleado.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkEmpleado.LinkColor = Color.White;
            lnkEmpleado.Location = new Point(13, 350);
            lnkEmpleado.Name = "lnkEmpleado";
            lnkEmpleado.Size = new Size(101, 26);
            lnkEmpleado.TabIndex = 4;
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
            lnkProducto.Location = new Point(13, 301);
            lnkProducto.Name = "lnkProducto";
            lnkProducto.Size = new Size(93, 26);
            lnkProducto.TabIndex = 3;
            lnkProducto.TabStop = true;
            lnkProducto.Text = "Producto";
            lnkProducto.LinkClicked += lnkProducto_LinkClicked;
            // 
            // lnkCliente
            // 
            lnkCliente.ActiveLinkColor = Color.Black;
            lnkCliente.AutoSize = true;
            lnkCliente.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkCliente.LinkColor = Color.White;
            lnkCliente.Location = new Point(13, 257);
            lnkCliente.Name = "lnkCliente";
            lnkCliente.Size = new Size(74, 26);
            lnkCliente.TabIndex = 2;
            lnkCliente.TabStop = true;
            lnkCliente.Text = "Cliente";
            lnkCliente.LinkClicked += lnkCliente_LinkClicked;
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
            lnkPedido.LinkClicked += lnkPedido_LinkClicked_1;
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
            panel3.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(725, 60);
            label2.Name = "label2";
            label2.Size = new Size(245, 21);
            label2.TabIndex = 5;
            label2.Text = "Gestion del apartado de categoria.";
            // 
            // gpxCategoriaAgregar
            // 
            gpxCategoriaAgregar.Controls.Add(btnCategoriaCancelar);
            gpxCategoriaAgregar.Controls.Add(txtCategoriaDescripcion);
            gpxCategoriaAgregar.Controls.Add(btnCategoriaAgregar);
            gpxCategoriaAgregar.Controls.Add(txtCategoriaNombre);
            gpxCategoriaAgregar.Controls.Add(label5);
            gpxCategoriaAgregar.Controls.Add(label4);
            gpxCategoriaAgregar.Location = new Point(215, 86);
            gpxCategoriaAgregar.Name = "gpxCategoriaAgregar";
            gpxCategoriaAgregar.Size = new Size(970, 172);
            gpxCategoriaAgregar.TabIndex = 14;
            gpxCategoriaAgregar.TabStop = false;
            gpxCategoriaAgregar.Text = "Agregar categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 38);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 15;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 72);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 16;
            label5.Text = "Descripcion:";
            // 
            // txtCategoriaNombre
            // 
            txtCategoriaNombre.Location = new Point(111, 35);
            txtCategoriaNombre.Name = "txtCategoriaNombre";
            txtCategoriaNombre.Size = new Size(846, 26);
            txtCategoriaNombre.TabIndex = 17;
            // 
            // txtCategoriaDescripcion
            // 
            txtCategoriaDescripcion.Location = new Point(111, 72);
            txtCategoriaDescripcion.Name = "txtCategoriaDescripcion";
            txtCategoriaDescripcion.Size = new Size(846, 26);
            txtCategoriaDescripcion.TabIndex = 18;
            // 
            // btnCategoriaCancelar
            // 
            btnCategoriaCancelar.Cursor = Cursors.Hand;
            btnCategoriaCancelar.Location = new Point(14, 125);
            btnCategoriaCancelar.Name = "btnCategoriaCancelar";
            btnCategoriaCancelar.Size = new Size(134, 34);
            btnCategoriaCancelar.TabIndex = 28;
            btnCategoriaCancelar.Text = "Cancelar";
            btnCategoriaCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCategoriaAgregar
            // 
            btnCategoriaAgregar.Cursor = Cursors.Hand;
            btnCategoriaAgregar.Location = new Point(809, 125);
            btnCategoriaAgregar.Name = "btnCategoriaAgregar";
            btnCategoriaAgregar.Size = new Size(148, 34);
            btnCategoriaAgregar.TabIndex = 27;
            btnCategoriaAgregar.Text = "Agregar categoria";
            btnCategoriaAgregar.UseVisualStyleBackColor = true;
            // 
            // gpxCategoriaConsulta
            // 
            gpxCategoriaConsulta.Controls.Add(btnClienteEliminar);
            gpxCategoriaConsulta.Controls.Add(btnClienteModificar);
            gpxCategoriaConsulta.Controls.Add(dgvCategoriaConsultar);
            gpxCategoriaConsulta.Location = new Point(215, 264);
            gpxCategoriaConsulta.Name = "gpxCategoriaConsulta";
            gpxCategoriaConsulta.Size = new Size(970, 419);
            gpxCategoriaConsulta.TabIndex = 15;
            gpxCategoriaConsulta.TabStop = false;
            gpxCategoriaConsulta.Text = "Consulta de categorias";
            // 
            // dgvCategoriaConsultar
            // 
            dgvCategoriaConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoriaConsultar.Columns.AddRange(new DataGridViewColumn[] { Nombre, Descripcion });
            dgvCategoriaConsultar.Location = new Point(6, 25);
            dgvCategoriaConsultar.Name = "dgvCategoriaConsultar";
            dgvCategoriaConsultar.RowTemplate.Height = 25;
            dgvCategoriaConsultar.Size = new Size(780, 388);
            dgvCategoriaConsultar.TabIndex = 0;
            // 
            // btnClienteEliminar
            // 
            btnClienteEliminar.Cursor = Cursors.Hand;
            btnClienteEliminar.Location = new Point(792, 68);
            btnClienteEliminar.Name = "btnClienteEliminar";
            btnClienteEliminar.Size = new Size(165, 40);
            btnClienteEliminar.TabIndex = 19;
            btnClienteEliminar.Text = "Eliminar";
            btnClienteEliminar.UseVisualStyleBackColor = true;
            // 
            // btnClienteModificar
            // 
            btnClienteModificar.Cursor = Cursors.Hand;
            btnClienteModificar.Location = new Point(792, 23);
            btnClienteModificar.Name = "btnClienteModificar";
            btnClienteModificar.Size = new Size(165, 40);
            btnClienteModificar.TabIndex = 18;
            btnClienteModificar.Text = "Modificar";
            btnClienteModificar.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // category
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 681);
            ControlBox = false;
            Controls.Add(gpxCategoriaConsulta);
            Controls.Add(gpxCategoriaAgregar);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "category";
            Text = "Espresso Esencial - Categoria";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            gpxCategoriaAgregar.ResumeLayout(false);
            gpxCategoriaAgregar.PerformLayout();
            gpxCategoriaConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategoriaConsultar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private LinkLabel lnkProveedor;
        private LinkLabel lnkEmpleado;
        private LinkLabel lnkProducto;
        private LinkLabel lnkCliente;
        private LinkLabel lnkPedido;
        private LinkLabel lnkInicio;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private LinkLabel lnkIngrediente;
        private Label label7;
        private Label lblEmpleado;
        private GroupBox gpxCategoriaAgregar;
        private TextBox txtCategoriaDescripcion;
        private TextBox txtCategoriaNombre;
        private Label label5;
        private Label label4;
        private Button btnCategoriaCancelar;
        private Button btnCategoriaAgregar;
        private GroupBox gpxCategoriaConsulta;
        private DataGridView dgvCategoriaConsultar;
        private Button btnClienteEliminar;
        private Button btnClienteModificar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
    }
}