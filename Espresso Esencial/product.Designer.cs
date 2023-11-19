namespace Espresso_Esencial
{
    partial class product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            label1 = new Label();
            panel1 = new Panel();
            lnkIngrediente = new LinkLabel();
            label7 = new Label();
            lblEmpleado = new Label();
            lnkProveedor = new LinkLabel();
            lnkCategoria = new LinkLabel();
            lnkEmpleado = new LinkLabel();
            lnkCliente = new LinkLabel();
            lnkPedido = new LinkLabel();
            lnkInicio = new LinkLabel();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label15 = new Label();
            btnProductoCancelar = new Button();
            btnProductoAgregar = new Button();
            cbxProductoCategoria = new ComboBox();
            label13 = new Label();
            btnProductoAgregaIngrediente = new Button();
            txtProductoCantidadNecesariaIngrediente = new TextBox();
            label12 = new Label();
            label11 = new Label();
            cbxProductoIngrediente = new ComboBox();
            txtProductoCantidadMinima = new TextBox();
            label10 = new Label();
            txtProductoCantidadActual = new TextBox();
            label9 = new Label();
            txtPrecioProducto = new TextBox();
            label8 = new Label();
            label6 = new Label();
            txtDescripcionProducto = new TextBox();
            txtNombreProducto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            Ingrediente = new DataGridViewTextBoxColumn();
            CantidadNecesaria = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            label14 = new Label();
            dgvConsultaProducto = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            CantidadActual = new DataGridViewTextBoxColumn();
            CantidadMinima = new DataGridViewTextBoxColumn();
            btnProductoEliminar = new Button();
            btnProductoConsultar = new Button();
            btnProductoModificar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 4;
            label1.Text = "Producto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(lnkIngrediente);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblEmpleado);
            panel1.Controls.Add(lnkProveedor);
            panel1.Controls.Add(lnkCategoria);
            panel1.Controls.Add(lnkEmpleado);
            panel1.Controls.Add(lnkCliente);
            panel1.Controls.Add(lnkPedido);
            panel1.Controls.Add(lnkInicio);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 683);
            panel1.TabIndex = 12;
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
            lnkIngrediente.TabIndex = 9;
            lnkIngrediente.TabStop = true;
            lnkIngrediente.Text = "Ingrediente";
            lnkIngrediente.LinkClicked += lnkIngrediente_LinkClicked;
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
            panel3.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(728, 60);
            label2.Name = "label2";
            label2.Size = new Size(242, 21);
            label2.TabIndex = 5;
            label2.Text = "Gestion del apartado de producto.";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(215, 83);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(970, 599);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(btnProductoCancelar);
            tabPage1.Controls.Add(btnProductoAgregar);
            tabPage1.Controls.Add(cbxProductoCategoria);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(btnProductoAgregaIngrediente);
            tabPage1.Controls.Add(txtProductoCantidadNecesariaIngrediente);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(cbxProductoIngrediente);
            tabPage1.Controls.Add(txtProductoCantidadMinima);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtProductoCantidadActual);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtPrecioProducto);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtDescripcionProducto);
            tabPage1.Controls.Add(txtNombreProducto);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(962, 565);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(9, 7);
            label15.Name = "label15";
            label15.Size = new Size(167, 26);
            label15.TabIndex = 21;
            label15.Text = "Agregar producto";
            // 
            // btnProductoCancelar
            // 
            btnProductoCancelar.Cursor = Cursors.Hand;
            btnProductoCancelar.Location = new Point(6, 498);
            btnProductoCancelar.Name = "btnProductoCancelar";
            btnProductoCancelar.Size = new Size(134, 58);
            btnProductoCancelar.TabIndex = 20;
            btnProductoCancelar.Text = "Cancelar producto";
            btnProductoCancelar.UseVisualStyleBackColor = true;
            // 
            // btnProductoAgregar
            // 
            btnProductoAgregar.Cursor = Cursors.Hand;
            btnProductoAgregar.Location = new Point(454, 498);
            btnProductoAgregar.Name = "btnProductoAgregar";
            btnProductoAgregar.Size = new Size(134, 58);
            btnProductoAgregar.TabIndex = 19;
            btnProductoAgregar.Text = "Agregar producto";
            btnProductoAgregar.UseVisualStyleBackColor = true;
            // 
            // cbxProductoCategoria
            // 
            cbxProductoCategoria.FormattingEnabled = true;
            cbxProductoCategoria.Location = new Point(180, 70);
            cbxProductoCategoria.Name = "cbxProductoCategoria";
            cbxProductoCategoria.Size = new Size(405, 29);
            cbxProductoCategoria.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 73);
            label13.Name = "label13";
            label13.Size = new Size(168, 21);
            label13.TabIndex = 17;
            label13.Text = "Categoria del producto:";
            // 
            // btnProductoAgregaIngrediente
            // 
            btnProductoAgregaIngrediente.Cursor = Cursors.Hand;
            btnProductoAgregaIngrediente.Location = new Point(452, 350);
            btnProductoAgregaIngrediente.Name = "btnProductoAgregaIngrediente";
            btnProductoAgregaIngrediente.Size = new Size(133, 53);
            btnProductoAgregaIngrediente.TabIndex = 16;
            btnProductoAgregaIngrediente.Text = "Agregar ingrediente";
            btnProductoAgregaIngrediente.UseVisualStyleBackColor = true;
            // 
            // txtProductoCantidadNecesariaIngrediente
            // 
            txtProductoCantidadNecesariaIngrediente.Location = new Point(277, 374);
            txtProductoCantidadNecesariaIngrediente.Name = "txtProductoCantidadNecesariaIngrediente";
            txtProductoCantidadNecesariaIngrediente.Size = new Size(147, 26);
            txtProductoCantidadNecesariaIngrediente.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(277, 349);
            label12.Name = "label12";
            label12.Size = new Size(147, 21);
            label12.TabIndex = 14;
            label12.Text = "Cantidad necesaria:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 349);
            label11.Name = "label11";
            label11.Size = new Size(98, 21);
            label11.TabIndex = 13;
            label11.Text = "Ingredientes:";
            // 
            // cbxProductoIngrediente
            // 
            cbxProductoIngrediente.FormattingEnabled = true;
            cbxProductoIngrediente.Location = new Point(9, 374);
            cbxProductoIngrediente.Name = "cbxProductoIngrediente";
            cbxProductoIngrediente.Size = new Size(247, 29);
            cbxProductoIngrediente.TabIndex = 12;
            // 
            // txtProductoCantidadMinima
            // 
            txtProductoCantidadMinima.Location = new Point(458, 299);
            txtProductoCantidadMinima.Name = "txtProductoCantidadMinima";
            txtProductoCantidadMinima.Size = new Size(127, 26);
            txtProductoCantidadMinima.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(317, 302);
            label10.Name = "label10";
            label10.Size = new Size(135, 21);
            label10.TabIndex = 10;
            label10.Text = "Cantidad minima:";
            // 
            // txtProductoCantidadActual
            // 
            txtProductoCantidadActual.Location = new Point(141, 299);
            txtProductoCantidadActual.Name = "txtProductoCantidadActual";
            txtProductoCantidadActual.Size = new Size(127, 26);
            txtProductoCantidadActual.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 302);
            label9.Name = "label9";
            label9.Size = new Size(124, 21);
            label9.TabIndex = 8;
            label9.Text = "Cantidad actual:";
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(163, 246);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(422, 26);
            txtPrecioProducto.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 249);
            label8.Name = "label8";
            label8.Size = new Size(158, 21);
            label8.TabIndex = 6;
            label8.Text = "Precio del producto: $";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 171);
            label6.Name = "label6";
            label6.Size = new Size(181, 21);
            label6.TabIndex = 5;
            label6.Text = "Descripcion del producto:";
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.Location = new Point(6, 195);
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(579, 26);
            txtDescripcionProducto.TabIndex = 4;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(6, 132);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(579, 26);
            txtNombreProducto.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 108);
            label4.Name = "label4";
            label4.Size = new Size(157, 21);
            label4.TabIndex = 2;
            label4.Text = "Nombre del producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(594, 44);
            label5.Name = "label5";
            label5.Size = new Size(98, 21);
            label5.TabIndex = 1;
            label5.Text = "Ingredientes:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ingrediente, CantidadNecesaria });
            dataGridView1.Location = new Point(594, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(359, 488);
            dataGridView1.TabIndex = 0;
            // 
            // Ingrediente
            // 
            Ingrediente.HeaderText = "Ingrediente";
            Ingrediente.Name = "Ingrediente";
            // 
            // CantidadNecesaria
            // 
            CantidadNecesaria.HeaderText = "Cant necesaria";
            CantidadNecesaria.Name = "CantidadNecesaria";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(dgvConsultaProducto);
            tabPage2.Controls.Add(btnProductoEliminar);
            tabPage2.Controls.Add(btnProductoConsultar);
            tabPage2.Controls.Add(btnProductoModificar);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(962, 565);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(9, 7);
            label14.Name = "label14";
            label14.Size = new Size(200, 26);
            label14.TabIndex = 22;
            label14.Text = "Productos existentes";
            // 
            // dgvConsultaProducto
            // 
            dgvConsultaProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaProducto.Columns.AddRange(new DataGridViewColumn[] { Nombre, Descripcion, Precio, CantidadActual, CantidadMinima });
            dgvConsultaProducto.Location = new Point(6, 36);
            dgvConsultaProducto.Name = "dgvConsultaProducto";
            dgvConsultaProducto.RowTemplate.Height = 25;
            dgvConsultaProducto.Size = new Size(774, 520);
            dgvConsultaProducto.TabIndex = 8;
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
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
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
            // btnProductoEliminar
            // 
            btnProductoEliminar.Cursor = Cursors.Hand;
            btnProductoEliminar.Location = new Point(788, 145);
            btnProductoEliminar.Name = "btnProductoEliminar";
            btnProductoEliminar.Size = new Size(165, 40);
            btnProductoEliminar.TabIndex = 7;
            btnProductoEliminar.Text = "Eliminar";
            btnProductoEliminar.UseVisualStyleBackColor = true;
            // 
            // btnProductoConsultar
            // 
            btnProductoConsultar.Cursor = Cursors.Hand;
            btnProductoConsultar.Location = new Point(788, 35);
            btnProductoConsultar.Name = "btnProductoConsultar";
            btnProductoConsultar.Size = new Size(165, 59);
            btnProductoConsultar.TabIndex = 6;
            btnProductoConsultar.Text = "Consultar ingredientes";
            btnProductoConsultar.UseVisualStyleBackColor = true;
            // 
            // btnProductoModificar
            // 
            btnProductoModificar.Cursor = Cursors.Hand;
            btnProductoModificar.Location = new Point(788, 100);
            btnProductoModificar.Name = "btnProductoModificar";
            btnProductoModificar.Size = new Size(165, 40);
            btnProductoModificar.TabIndex = 5;
            btnProductoModificar.Text = "Modificar";
            btnProductoModificar.UseVisualStyleBackColor = true;
            // 
            // product
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
            Name = "product";
            Text = "Espresso Esencial - Producto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private LinkLabel lnkProveedor;
        private LinkLabel lnkCategoria;
        private LinkLabel lnkEmpleado;
        private LinkLabel lnkCliente;
        private LinkLabel lnkPedido;
        private LinkLabel lnkInicio;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label7;
        private Label lblEmpleado;
        private TextBox txtNombreProducto;
        private Label label4;
        private ComboBox cbxProductoIngrediente;
        private TextBox txtProductoCantidadMinima;
        private Label label10;
        private TextBox txtProductoCantidadActual;
        private Label label9;
        private TextBox txtPrecioProducto;
        private Label label8;
        private Label label6;
        private TextBox txtDescripcionProducto;
        private Label label11;
        private ComboBox cbxProductoCategoria;
        private Label label13;
        private Button btnProductoAgregaIngrediente;
        private TextBox txtProductoCantidadNecesariaIngrediente;
        private Label label12;
        private Button btnProductoAgregar;
        private Button btnProductoCancelar;
        private Button btnProductoEliminar;
        private Button btnProductoConsultar;
        private Button btnProductoModificar;
        private DataGridView dgvConsultaProducto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn CantidadActual;
        private DataGridViewTextBoxColumn CantidadMinima;
        private DataGridViewTextBoxColumn Ingrediente;
        private DataGridViewTextBoxColumn CantidadNecesaria;
        private LinkLabel lnkIngrediente;
        private Label label15;
        private Label label14;
    }
}