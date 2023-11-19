namespace Espresso_Esencial
{
    partial class order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order));
            label1 = new Label();
            panel1 = new Panel();
            lnkIngrediente = new LinkLabel();
            label7 = new Label();
            lblEmpleado = new Label();
            lnkProveedor = new LinkLabel();
            lnkCategoria = new LinkLabel();
            lnkEmpleado = new LinkLabel();
            lnkProducto = new LinkLabel();
            lnkCliente = new LinkLabel();
            lnkInicio = new LinkLabel();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            tabAgregarConsultar = new TabControl();
            tabPage1 = new TabPage();
            label8 = new Label();
            lblTotal = new Label();
            label6 = new Label();
            label5 = new Label();
            btnPedidoCancelar = new Button();
            btnPedidoRealizar = new Button();
            dgvListaPedido = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            tabProductos = new TabControl();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            tabPage2 = new TabPage();
            btnPedidoEntregado = new Button();
            btnPedidoEliminar = new Button();
            btnPedidoConsultar = new Button();
            btnPedidoModificar = new Button();
            dgvConsultaPedido = new DataGridView();
            NumeroPedido = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            TotalPedido = new DataGridViewTextBoxColumn();
            Entregado = new DataGridViewTextBoxColumn();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabAgregarConsultar.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPedido).BeginInit();
            tabProductos.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaPedido).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 4;
            label1.Text = "Pedido";
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
            panel1.Controls.Add(lnkProducto);
            panel1.Controls.Add(lnkCliente);
            panel1.Controls.Add(lnkInicio);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 683);
            panel1.TabIndex = 5;
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
            lnkIngrediente.TabIndex = 8;
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
            label7.TabIndex = 7;
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
            lblEmpleado.TabIndex = 0;
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
            // lnkCliente
            // 
            lnkCliente.ActiveLinkColor = Color.Black;
            lnkCliente.AutoSize = true;
            lnkCliente.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnkCliente.LinkColor = Color.White;
            lnkCliente.Location = new Point(13, 213);
            lnkCliente.Name = "lnkCliente";
            lnkCliente.Size = new Size(74, 26);
            lnkCliente.TabIndex = 1;
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
            panel3.Location = new Point(214, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(970, 81);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(739, 60);
            label2.Name = "label2";
            label2.Size = new Size(229, 21);
            label2.TabIndex = 5;
            label2.Text = "Gestion del apartado de pedido.";
            // 
            // tabAgregarConsultar
            // 
            tabAgregarConsultar.Controls.Add(tabPage1);
            tabAgregarConsultar.Controls.Add(tabPage2);
            tabAgregarConsultar.Location = new Point(214, 83);
            tabAgregarConsultar.Name = "tabAgregarConsultar";
            tabAgregarConsultar.SelectedIndex = 0;
            tabAgregarConsultar.Size = new Size(970, 599);
            tabAgregarConsultar.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(lblTotal);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btnPedidoCancelar);
            tabPage1.Controls.Add(btnPedidoRealizar);
            tabPage1.Controls.Add(dgvListaPedido);
            tabPage1.Controls.Add(tabProductos);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(962, 565);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(9, 7);
            label8.Name = "label8";
            label8.Size = new Size(148, 26);
            label8.TabIndex = 7;
            label8.Text = "Agregar pedido";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(75, 481);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 21);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "00.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 481);
            label6.Name = "label6";
            label6.Size = new Size(19, 21);
            label6.TabIndex = 5;
            label6.Text = "$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 481);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 4;
            label5.Text = "Total:";
            // 
            // btnPedidoCancelar
            // 
            btnPedidoCancelar.Cursor = Cursors.Hand;
            btnPedidoCancelar.Location = new Point(9, 522);
            btnPedidoCancelar.Name = "btnPedidoCancelar";
            btnPedidoCancelar.Size = new Size(134, 34);
            btnPedidoCancelar.TabIndex = 3;
            btnPedidoCancelar.Text = "Cancelar pedido";
            btnPedidoCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPedidoRealizar
            // 
            btnPedidoRealizar.Cursor = Cursors.Hand;
            btnPedidoRealizar.Location = new Point(245, 522);
            btnPedidoRealizar.Name = "btnPedidoRealizar";
            btnPedidoRealizar.Size = new Size(134, 34);
            btnPedidoRealizar.TabIndex = 2;
            btnPedidoRealizar.Text = "Realizar pedido";
            btnPedidoRealizar.UseVisualStyleBackColor = true;
            // 
            // dgvListaPedido
            // 
            dgvListaPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaPedido.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, Total });
            dgvListaPedido.Location = new Point(6, 37);
            dgvListaPedido.Name = "dgvListaPedido";
            dgvListaPedido.RowTemplate.Height = 25;
            dgvListaPedido.Size = new Size(373, 441);
            dgvListaPedido.TabIndex = 1;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 75;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cant";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 50;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 75;
            // 
            // tabProductos
            // 
            tabProductos.Controls.Add(tabPage3);
            tabProductos.Controls.Add(tabPage4);
            tabProductos.Controls.Add(tabPage5);
            tabProductos.Controls.Add(tabPage6);
            tabProductos.Controls.Add(tabPage7);
            tabProductos.Controls.Add(tabPage8);
            tabProductos.Location = new Point(385, 7);
            tabProductos.Name = "tabProductos";
            tabProductos.SelectedIndex = 0;
            tabProductos.Size = new Size(577, 562);
            tabProductos.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(569, 528);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Cafes";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(569, 534);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Te";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(569, 534);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Alimentos";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(569, 534);
            tabPage6.TabIndex = 3;
            tabPage6.Text = "Jugos";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(569, 534);
            tabPage7.TabIndex = 4;
            tabPage7.Text = "Batidos";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(569, 534);
            tabPage8.TabIndex = 5;
            tabPage8.Text = "Productos extra";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnPedidoEntregado);
            tabPage2.Controls.Add(btnPedidoEliminar);
            tabPage2.Controls.Add(btnPedidoConsultar);
            tabPage2.Controls.Add(btnPedidoModificar);
            tabPage2.Controls.Add(dgvConsultaPedido);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(962, 565);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPedidoEntregado
            // 
            btnPedidoEntregado.Cursor = Cursors.Hand;
            btnPedidoEntregado.Location = new Point(789, 496);
            btnPedidoEntregado.Name = "btnPedidoEntregado";
            btnPedidoEntregado.Size = new Size(165, 60);
            btnPedidoEntregado.TabIndex = 5;
            btnPedidoEntregado.Text = "Marcar como entregado";
            btnPedidoEntregado.UseVisualStyleBackColor = true;
            // 
            // btnPedidoEliminar
            // 
            btnPedidoEliminar.Cursor = Cursors.Hand;
            btnPedidoEliminar.Location = new Point(789, 126);
            btnPedidoEliminar.Name = "btnPedidoEliminar";
            btnPedidoEliminar.Size = new Size(165, 40);
            btnPedidoEliminar.TabIndex = 4;
            btnPedidoEliminar.Text = "Eliminar";
            btnPedidoEliminar.UseVisualStyleBackColor = true;
            // 
            // btnPedidoConsultar
            // 
            btnPedidoConsultar.Cursor = Cursors.Hand;
            btnPedidoConsultar.Location = new Point(789, 35);
            btnPedidoConsultar.Name = "btnPedidoConsultar";
            btnPedidoConsultar.Size = new Size(165, 40);
            btnPedidoConsultar.TabIndex = 3;
            btnPedidoConsultar.Text = "Consultar";
            btnPedidoConsultar.UseVisualStyleBackColor = true;
            // 
            // btnPedidoModificar
            // 
            btnPedidoModificar.Cursor = Cursors.Hand;
            btnPedidoModificar.Location = new Point(789, 81);
            btnPedidoModificar.Name = "btnPedidoModificar";
            btnPedidoModificar.Size = new Size(165, 40);
            btnPedidoModificar.TabIndex = 2;
            btnPedidoModificar.Text = "Modificar";
            btnPedidoModificar.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaPedido
            // 
            dgvConsultaPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaPedido.Columns.AddRange(new DataGridViewColumn[] { NumeroPedido, Fecha, Hora, TotalPedido, Entregado });
            dgvConsultaPedido.Location = new Point(9, 36);
            dgvConsultaPedido.Name = "dgvConsultaPedido";
            dgvConsultaPedido.RowTemplate.Height = 25;
            dgvConsultaPedido.Size = new Size(774, 520);
            dgvConsultaPedido.TabIndex = 1;
            // 
            // NumeroPedido
            // 
            NumeroPedido.HeaderText = "Numero pedido";
            NumeroPedido.Name = "NumeroPedido";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            // 
            // TotalPedido
            // 
            TotalPedido.HeaderText = "Total";
            TotalPedido.Name = "TotalPedido";
            // 
            // Entregado
            // 
            Entregado.HeaderText = "Entregado";
            Entregado.Name = "Entregado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 7);
            label4.Name = "label4";
            label4.Size = new Size(180, 26);
            label4.TabIndex = 0;
            label4.Text = "Pedidos realizados";
            // 
            // order
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 681);
            ControlBox = false;
            Controls.Add(tabAgregarConsultar);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "order";
            Text = "Espresso Esencial - Pedido";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabAgregarConsultar.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPedido).EndInit();
            tabProductos.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaPedido).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private TabControl tabAgregarConsultar;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private LinkLabel lnkInicio;
        private LinkLabel lnkProveedor;
        private LinkLabel lnkCategoria;
        private LinkLabel lnkEmpleado;
        private LinkLabel lnkProducto;
        private LinkLabel lnkCliente;
        private Label lblEmpleado;
        private TabControl tabProductos;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Button btnPedidoCancelar;
        private Button btnPedidoRealizar;
        private DataGridView dgvListaPedido;
        private TabPage tabPage8;
        private Label lblTotal;
        private Label label6;
        private Label label5;
        private Label label7;
        private DataGridView dgvConsultaPedido;
        private Label label4;
        private Button btnPedidoEntregado;
        private Button btnPedidoEliminar;
        private Button btnPedidoConsultar;
        private Button btnPedidoModificar;
        private LinkLabel lnkIngrediente;
        private Label label8;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn NumeroPedido;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn TotalPedido;
        private DataGridViewTextBoxColumn Entregado;
    }
}