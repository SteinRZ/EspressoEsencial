namespace Espresso_Esencial
{
    partial class ingredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingredient));
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            lblEmpleado = new Label();
            lnkProveedor = new LinkLabel();
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnIngredienteCancelar = new Button();
            btnIngredienteAgregar = new Button();
            cbxIngredienteProveedor = new ComboBox();
            label4 = new Label();
            label15 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtIngredienteNombre = new TextBox();
            txtIngredienteDescripcion = new TextBox();
            label8 = new Label();
            txtIngredienteCantidadMinima = new TextBox();
            label10 = new Label();
            txtIngredienteCantidadActual = new TextBox();
            label9 = new Label();
            label11 = new Label();
            dtpIngredienteCaducidad = new DateTimePicker();
            btnIngredienteEliminar = new Button();
            btnIngredienteModificar = new Button();
            dgvConsultaCliente = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            CantidadActual = new DataGridViewTextBoxColumn();
            CantidadMinima = new DataGridViewTextBoxColumn();
            Caducidad = new DataGridViewTextBoxColumn();
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
            label1.Size = new Size(131, 30);
            label1.TabIndex = 4;
            label1.Text = "Ingrediente";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblEmpleado);
            panel1.Controls.Add(lnkProveedor);
            panel1.Controls.Add(lnkCategoria);
            panel1.Controls.Add(lnkEmpleado);
            panel1.Controls.Add(lnkPedido);
            panel1.Controls.Add(lnkProducto);
            panel1.Controls.Add(lnkCliente);
            panel1.Controls.Add(lnkInicio);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 683);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 2);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 21;
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
            lblEmpleado.TabIndex = 20;
            lblEmpleado.Text = "nombre_empleado";
            // 
            // lnkProveedor
            // 
            lnkProveedor.ActiveLinkColor = Color.Black;
            lnkProveedor.AutoSize = true;
            lnkProveedor.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkProveedor.LinkColor = Color.White;
            lnkProveedor.Location = new Point(13, 446);
            lnkProveedor.Name = "lnkProveedor";
            lnkProveedor.Size = new Size(103, 26);
            lnkProveedor.TabIndex = 19;
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
            panel3.Location = new Point(215, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(970, 81);
            panel3.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(708, 60);
            label2.Name = "label2";
            label2.Size = new Size(259, 21);
            label2.TabIndex = 5;
            label2.Text = "Gestion del apartado de ingrediente.";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(215, 82);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(970, 599);
            tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtpIngredienteCaducidad);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(txtIngredienteCantidadMinima);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtIngredienteCantidadActual);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtIngredienteDescripcion);
            tabPage1.Controls.Add(txtIngredienteNombre);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(cbxIngredienteProveedor);
            tabPage1.Controls.Add(btnIngredienteCancelar);
            tabPage1.Controls.Add(btnIngredienteAgregar);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(962, 565);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnIngredienteEliminar);
            tabPage2.Controls.Add(btnIngredienteModificar);
            tabPage2.Controls.Add(dgvConsultaCliente);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(962, 565);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnIngredienteCancelar
            // 
            btnIngredienteCancelar.Cursor = Cursors.Hand;
            btnIngredienteCancelar.Location = new Point(10, 522);
            btnIngredienteCancelar.Name = "btnIngredienteCancelar";
            btnIngredienteCancelar.Size = new Size(134, 34);
            btnIngredienteCancelar.TabIndex = 54;
            btnIngredienteCancelar.Text = "Cancelar";
            btnIngredienteCancelar.UseVisualStyleBackColor = true;
            // 
            // btnIngredienteAgregar
            // 
            btnIngredienteAgregar.Cursor = Cursors.Hand;
            btnIngredienteAgregar.Location = new Point(803, 522);
            btnIngredienteAgregar.Name = "btnIngredienteAgregar";
            btnIngredienteAgregar.Size = new Size(150, 34);
            btnIngredienteAgregar.TabIndex = 53;
            btnIngredienteAgregar.Text = "Agregar ingrediente";
            btnIngredienteAgregar.UseVisualStyleBackColor = true;
            // 
            // cbxIngredienteProveedor
            // 
            cbxIngredienteProveedor.FormattingEnabled = true;
            cbxIngredienteProveedor.Location = new Point(110, 121);
            cbxIngredienteProveedor.Name = "cbxIngredienteProveedor";
            cbxIngredienteProveedor.Size = new Size(843, 29);
            cbxIngredienteProveedor.TabIndex = 55;
            cbxIngredienteProveedor.Text = "Proveedor del ingrediente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 124);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 56;
            label4.Text = "Proveedor:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(9, 7);
            label15.Name = "label15";
            label15.Size = new Size(189, 26);
            label15.TabIndex = 57;
            label15.Text = "Agregar ingrediente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 7);
            label5.Name = "label5";
            label5.Size = new Size(203, 26);
            label5.TabIndex = 58;
            label5.Text = "Consultar ingrediente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 173);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 58;
            label6.Text = "Nombre:";
            // 
            // txtIngredienteNombre
            // 
            txtIngredienteNombre.Location = new Point(22, 197);
            txtIngredienteNombre.Name = "txtIngredienteNombre";
            txtIngredienteNombre.Size = new Size(342, 26);
            txtIngredienteNombre.TabIndex = 59;
            // 
            // txtIngredienteDescripcion
            // 
            txtIngredienteDescripcion.Location = new Point(370, 197);
            txtIngredienteDescripcion.Name = "txtIngredienteDescripcion";
            txtIngredienteDescripcion.Size = new Size(583, 26);
            txtIngredienteDescripcion.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(385, 173);
            label8.Name = "label8";
            label8.Size = new Size(92, 21);
            label8.TabIndex = 61;
            label8.Text = "Descripcion:";
            // 
            // txtIngredienteCantidadMinima
            // 
            txtIngredienteCantidadMinima.Location = new Point(250, 268);
            txtIngredienteCantidadMinima.Name = "txtIngredienteCantidadMinima";
            txtIngredienteCantidadMinima.Size = new Size(135, 26);
            txtIngredienteCantidadMinima.TabIndex = 65;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(250, 244);
            label10.Name = "label10";
            label10.Size = new Size(135, 21);
            label10.TabIndex = 64;
            label10.Text = "Cantidad minima:";
            // 
            // txtIngredienteCantidadActual
            // 
            txtIngredienteCantidadActual.Location = new Point(33, 268);
            txtIngredienteCantidadActual.Name = "txtIngredienteCantidadActual";
            txtIngredienteCantidadActual.Size = new Size(127, 26);
            txtIngredienteCantidadActual.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 244);
            label9.Name = "label9";
            label9.Size = new Size(124, 21);
            label9.TabIndex = 62;
            label9.Text = "Cantidad actual:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(463, 244);
            label11.Name = "label11";
            label11.Size = new Size(88, 21);
            label11.TabIndex = 66;
            label11.Text = "Caducidad:";
            // 
            // dtpIngredienteCaducidad
            // 
            dtpIngredienteCaducidad.Location = new Point(463, 268);
            dtpIngredienteCaducidad.Name = "dtpIngredienteCaducidad";
            dtpIngredienteCaducidad.Size = new Size(306, 26);
            dtpIngredienteCaducidad.TabIndex = 67;
            // 
            // btnIngredienteEliminar
            // 
            btnIngredienteEliminar.Cursor = Cursors.Hand;
            btnIngredienteEliminar.Location = new Point(791, 85);
            btnIngredienteEliminar.Name = "btnIngredienteEliminar";
            btnIngredienteEliminar.Size = new Size(165, 40);
            btnIngredienteEliminar.TabIndex = 61;
            btnIngredienteEliminar.Text = "Eliminar";
            btnIngredienteEliminar.UseVisualStyleBackColor = true;
            // 
            // btnIngredienteModificar
            // 
            btnIngredienteModificar.Cursor = Cursors.Hand;
            btnIngredienteModificar.Location = new Point(791, 39);
            btnIngredienteModificar.Name = "btnIngredienteModificar";
            btnIngredienteModificar.Size = new Size(165, 40);
            btnIngredienteModificar.TabIndex = 60;
            btnIngredienteModificar.Text = "Modificar";
            btnIngredienteModificar.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaCliente
            // 
            dgvConsultaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaCliente.Columns.AddRange(new DataGridViewColumn[] { Nombre, Descripcion, Proveedor, CantidadActual, CantidadMinima, Caducidad });
            dgvConsultaCliente.Location = new Point(6, 39);
            dgvConsultaCliente.Name = "dgvConsultaCliente";
            dgvConsultaCliente.RowTemplate.Height = 25;
            dgvConsultaCliente.Size = new Size(779, 520);
            dgvConsultaCliente.TabIndex = 59;
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
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            // 
            // CantidadActual
            // 
            CantidadActual.HeaderText = "Cant actual";
            CantidadActual.Name = "CantidadActual";
            // 
            // CantidadMinima
            // 
            CantidadMinima.HeaderText = "Cant minima";
            CantidadMinima.Name = "CantidadMinima";
            // 
            // Caducidad
            // 
            Caducidad.HeaderText = "Caducidad";
            Caducidad.Name = "Caducidad";
            // 
            // ingredient
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
            Name = "ingredient";
            Text = "Espresso Esencia - Ingrediente";
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
        private LinkLabel lnkCategoria;
        private LinkLabel lnkEmpleado;
        private LinkLabel lnkPedido;
        private LinkLabel lnkProducto;
        private LinkLabel lnkCliente;
        private LinkLabel lnkInicio;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private LinkLabel lnkProveedor;
        private Label label7;
        private Label lblEmpleado;
        private Button btnIngredienteCancelar;
        private Button btnIngredienteAgregar;
        private Label label4;
        private ComboBox cbxIngredienteProveedor;
        private Label label15;
        private Label label5;
        private Label label6;
        private TextBox txtIngredienteNombre;
        private Label label8;
        private TextBox txtIngredienteDescripcion;
        private DateTimePicker dtpIngredienteCaducidad;
        private Label label11;
        private TextBox txtIngredienteCantidadMinima;
        private Label label10;
        private TextBox txtIngredienteCantidadActual;
        private Label label9;
        private Button btnIngredienteEliminar;
        private Button btnIngredienteModificar;
        private DataGridView dgvConsultaCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn CantidadActual;
        private DataGridViewTextBoxColumn CantidadMinima;
        private DataGridViewTextBoxColumn Caducidad;
    }
}