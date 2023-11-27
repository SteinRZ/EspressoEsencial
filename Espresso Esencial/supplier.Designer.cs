namespace Espresso_Esencial
{
    partial class supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier));
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            lblEmpleado = new Label();
            lnkIngrediente = new LinkLabel();
            lnkCategoria = new LinkLabel();
            lnkEmpleado = new LinkLabel();
            lnkPedido = new LinkLabel();
            lnkProducto = new LinkLabel();
            lnkCliente = new LinkLabel();
            lnkInicio = new LinkLabel();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            gpxProveedorAgregar = new GroupBox();
            btnProveedorCancelar = new Button();
            txtProveedorTelefono = new TextBox();
            btnProveedorAgregar = new Button();
            txtProveedorNombre = new TextBox();
            label11 = new Label();
            label12 = new Label();
            gpxCategoriaConsulta = new GroupBox();
            btnProveedorEliminar = new Button();
            dgvProveedorConsultar = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            gpxProveedorAgregar.SuspendLayout();
            gpxCategoriaConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedorConsultar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 4;
            label1.Text = "Proveedor";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblEmpleado);
            panel1.Controls.Add(lnkIngrediente);
            panel1.Controls.Add(lnkCategoria);
            panel1.Controls.Add(lnkEmpleado);
            panel1.Controls.Add(lnkPedido);
            panel1.Controls.Add(lnkProducto);
            panel1.Controls.Add(lnkCliente);
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
            label7.TabIndex = 20;
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
            lblEmpleado.TabIndex = 19;
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
            lnkIngrediente.TabIndex = 17;
            lnkIngrediente.TabStop = true;
            lnkIngrediente.Text = "Ingrediente";
            lnkIngrediente.LinkClicked += lnkIngrediente_LinkClicked;
            // 
            // lnkCategoria
            // 
            lnkCategoria.ActiveLinkColor = Color.Black;
            lnkCategoria.AutoSize = true;
            lnkCategoria.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkCategoria.LinkColor = Color.White;
            lnkCategoria.Location = new Point(13, 399);
            lnkCategoria.Name = "lnkCategoria";
            lnkCategoria.Size = new Size(98, 26);
            lnkCategoria.TabIndex = 18;
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
            lnkEmpleado.Location = new Point(13, 350);
            lnkEmpleado.Name = "lnkEmpleado";
            lnkEmpleado.Size = new Size(101, 26);
            lnkEmpleado.TabIndex = 17;
            lnkEmpleado.TabStop = true;
            lnkEmpleado.Text = "Empleado";
            lnkEmpleado.LinkClicked += lnkEmpleado_LinkClicked;
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
            // lnkProducto
            // 
            lnkProducto.ActiveLinkColor = Color.Black;
            lnkProducto.AutoSize = true;
            lnkProducto.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkProducto.LinkColor = Color.White;
            lnkProducto.Location = new Point(13, 301);
            lnkProducto.Name = "lnkProducto";
            lnkProducto.Size = new Size(93, 26);
            lnkProducto.TabIndex = 16;
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
            lnkCliente.TabIndex = 15;
            lnkCliente.TabStop = true;
            lnkCliente.Text = "Cliente";
            lnkCliente.LinkClicked += lnkCliente_LinkClicked;
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
            label2.Location = new Point(721, 60);
            label2.Name = "label2";
            label2.Size = new Size(249, 21);
            label2.TabIndex = 5;
            label2.Text = "Gestion del apartado de proveedor.";
            // 
            // gpxProveedorAgregar
            // 
            gpxProveedorAgregar.Controls.Add(btnProveedorCancelar);
            gpxProveedorAgregar.Controls.Add(txtProveedorTelefono);
            gpxProveedorAgregar.Controls.Add(btnProveedorAgregar);
            gpxProveedorAgregar.Controls.Add(txtProveedorNombre);
            gpxProveedorAgregar.Controls.Add(label11);
            gpxProveedorAgregar.Controls.Add(label12);
            gpxProveedorAgregar.Location = new Point(215, 86);
            gpxProveedorAgregar.Name = "gpxProveedorAgregar";
            gpxProveedorAgregar.Size = new Size(970, 172);
            gpxProveedorAgregar.TabIndex = 16;
            gpxProveedorAgregar.TabStop = false;
            gpxProveedorAgregar.Text = "Agregar proveedor";
            // 
            // btnProveedorCancelar
            // 
            btnProveedorCancelar.Cursor = Cursors.Hand;
            btnProveedorCancelar.Location = new Point(14, 125);
            btnProveedorCancelar.Name = "btnProveedorCancelar";
            btnProveedorCancelar.Size = new Size(134, 34);
            btnProveedorCancelar.TabIndex = 28;
            btnProveedorCancelar.Text = "Cancelar";
            btnProveedorCancelar.UseVisualStyleBackColor = true;
            // 
            // txtProveedorTelefono
            // 
            txtProveedorTelefono.Location = new Point(111, 72);
            txtProveedorTelefono.Name = "txtProveedorTelefono";
            txtProveedorTelefono.Size = new Size(846, 26);
            txtProveedorTelefono.TabIndex = 18;
            // 
            // btnProveedorAgregar
            // 
            btnProveedorAgregar.Cursor = Cursors.Hand;
            btnProveedorAgregar.Location = new Point(809, 125);
            btnProveedorAgregar.Name = "btnProveedorAgregar";
            btnProveedorAgregar.Size = new Size(148, 34);
            btnProveedorAgregar.TabIndex = 27;
            btnProveedorAgregar.Text = "Agregar proveedor";
            btnProveedorAgregar.UseVisualStyleBackColor = true;
            btnProveedorAgregar.Click += btnProveedorAgregar_Click;
            // 
            // txtProveedorNombre
            // 
            txtProveedorNombre.Location = new Point(111, 35);
            txtProveedorNombre.Name = "txtProveedorNombre";
            txtProveedorNombre.Size = new Size(846, 26);
            txtProveedorNombre.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 75);
            label11.Name = "label11";
            label11.Size = new Size(72, 21);
            label11.TabIndex = 16;
            label11.Text = "Telefono:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 38);
            label12.Name = "label12";
            label12.Size = new Size(68, 21);
            label12.TabIndex = 15;
            label12.Text = "Nombre:";
            // 
            // gpxCategoriaConsulta
            // 
            gpxCategoriaConsulta.Controls.Add(btnProveedorEliminar);
            gpxCategoriaConsulta.Controls.Add(dgvProveedorConsultar);
            gpxCategoriaConsulta.Location = new Point(215, 264);
            gpxCategoriaConsulta.Name = "gpxCategoriaConsulta";
            gpxCategoriaConsulta.Size = new Size(970, 419);
            gpxCategoriaConsulta.TabIndex = 17;
            gpxCategoriaConsulta.TabStop = false;
            gpxCategoriaConsulta.Text = "Consulta de proveedores";
            // 
            // btnProveedorEliminar
            // 
            btnProveedorEliminar.Cursor = Cursors.Hand;
            btnProveedorEliminar.Location = new Point(792, 25);
            btnProveedorEliminar.Name = "btnProveedorEliminar";
            btnProveedorEliminar.Size = new Size(165, 40);
            btnProveedorEliminar.TabIndex = 19;
            btnProveedorEliminar.Text = "Eliminar";
            btnProveedorEliminar.UseVisualStyleBackColor = true;
            btnProveedorEliminar.Click += btnProveedorEliminar_Click;
            // 
            // dgvProveedorConsultar
            // 
            dgvProveedorConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedorConsultar.Location = new Point(6, 25);
            dgvProveedorConsultar.Name = "dgvProveedorConsultar";
            dgvProveedorConsultar.RowTemplate.Height = 25;
            dgvProveedorConsultar.Size = new Size(780, 388);
            dgvProveedorConsultar.TabIndex = 0;
            // 
            // supplier
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 681);
            ControlBox = false;
            Controls.Add(gpxProveedorAgregar);
            Controls.Add(gpxCategoriaConsulta);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "supplier";
            Text = "Espresso Esencial - Proveedor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            gpxProveedorAgregar.ResumeLayout(false);
            gpxProveedorAgregar.PerformLayout();
            gpxCategoriaConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedorConsultar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private LinkLabel lnkPedido;
        private LinkLabel lnkInicio;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private LinkLabel lnkCategoria;
        private LinkLabel lnkEmpleado;
        private LinkLabel lnkProducto;
        private LinkLabel lnkCliente;
        private LinkLabel lnkIngrediente;
        private Label label7;
        private Label lblEmpleado;
        private GroupBox gpxProveedorAgregar;
        private Button btnProveedorCancelar;
        private TextBox txtProveedorTelefono;
        private Button btnProveedorAgregar;
        private TextBox txtProveedorNombre;
        private Label label11;
        private Label label12;
        private GroupBox gpxCategoriaConsulta;
        private Button btnProveedorEliminar;
        private DataGridView dgvProveedorConsultar;
    }
}