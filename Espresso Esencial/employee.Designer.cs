namespace Espresso_Esencial
{
    partial class employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee));
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            lblEmpleado = new Label();
            lnkIngrediente = new LinkLabel();
            lnkProveedor = new LinkLabel();
            lnkCategoria = new LinkLabel();
            lnkProducto = new LinkLabel();
            lnkCliente = new LinkLabel();
            lnkPedido = new LinkLabel();
            lnkInicio = new LinkLabel();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            gpxDireccion = new GroupBox();
            txtEmpleadoColonia = new TextBox();
            label16 = new Label();
            txtEmpleadoNumeroCalle = new TextBox();
            label15 = new Label();
            txtEmpleadoCalle = new TextBox();
            label14 = new Label();
            label13 = new Label();
            txtEmpleadoRFC = new TextBox();
            btnEmpleadoCancelar = new Button();
            btnEmpleadoAgregar = new Button();
            cbxEmpleadoRol = new ComboBox();
            txtEmpleadoCorreo = new TextBox();
            txtEmpleadoTelefono = new TextBox();
            txtEmpleadoNombre = new TextBox();
            txtEmpleadoApellidoMaterno = new TextBox();
            txtEmpleadoApellidoPaterno = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            tabPage2 = new TabPage();
            btnEmpleadoEliminar = new Button();
            btnEmpleadoModificar = new Button();
            dgvConsultaCliente = new DataGridView();
            ApellidoPaterno = new DataGridViewTextBoxColumn();
            ApellidoMaterno = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            CorreoElectronico = new DataGridViewTextBoxColumn();
            RFC = new DataGridViewTextBoxColumn();
            Calle = new DataGridViewTextBoxColumn();
            NumeroCalle = new DataGridViewTextBoxColumn();
            Colonia = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label17 = new Label();
            txtEmpleadoContraseña = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            gpxDireccion.SuspendLayout();
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
            label1.Size = new Size(117, 30);
            label1.TabIndex = 4;
            label1.Text = "Empleado";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblEmpleado);
            panel1.Controls.Add(lnkIngrediente);
            panel1.Controls.Add(lnkProveedor);
            panel1.Controls.Add(lnkCategoria);
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
            label7.TabIndex = 17;
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
            lblEmpleado.TabIndex = 16;
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
            lnkIngrediente.TabIndex = 15;
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
            label2.Location = new Point(719, 60);
            label2.Name = "label2";
            label2.Size = new Size(251, 21);
            label2.TabIndex = 5;
            label2.Text = "Gestion del apartado de empleado.";
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
            tabPage1.Controls.Add(txtEmpleadoContraseña);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(gpxDireccion);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(txtEmpleadoRFC);
            tabPage1.Controls.Add(btnEmpleadoCancelar);
            tabPage1.Controls.Add(btnEmpleadoAgregar);
            tabPage1.Controls.Add(cbxEmpleadoRol);
            tabPage1.Controls.Add(txtEmpleadoCorreo);
            tabPage1.Controls.Add(txtEmpleadoTelefono);
            tabPage1.Controls.Add(txtEmpleadoNombre);
            tabPage1.Controls.Add(txtEmpleadoApellidoMaterno);
            tabPage1.Controls.Add(txtEmpleadoApellidoPaterno);
            tabPage1.Controls.Add(label12);
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
            // gpxDireccion
            // 
            gpxDireccion.Controls.Add(txtEmpleadoColonia);
            gpxDireccion.Controls.Add(label16);
            gpxDireccion.Controls.Add(txtEmpleadoNumeroCalle);
            gpxDireccion.Controls.Add(label15);
            gpxDireccion.Controls.Add(txtEmpleadoCalle);
            gpxDireccion.Controls.Add(label14);
            gpxDireccion.Location = new Point(9, 333);
            gpxDireccion.Name = "gpxDireccion";
            gpxDireccion.Size = new Size(943, 101);
            gpxDireccion.TabIndex = 43;
            gpxDireccion.TabStop = false;
            gpxDireccion.Text = "Direccion";
            // 
            // txtEmpleadoColonia
            // 
            txtEmpleadoColonia.Location = new Point(77, 65);
            txtEmpleadoColonia.Name = "txtEmpleadoColonia";
            txtEmpleadoColonia.Size = new Size(432, 26);
            txtEmpleadoColonia.TabIndex = 48;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 68);
            label16.Name = "label16";
            label16.Size = new Size(65, 21);
            label16.TabIndex = 47;
            label16.Text = "Colonia:";
            // 
            // txtEmpleadoNumeroCalle
            // 
            txtEmpleadoNumeroCalle.Location = new Point(671, 19);
            txtEmpleadoNumeroCalle.Name = "txtEmpleadoNumeroCalle";
            txtEmpleadoNumeroCalle.Size = new Size(266, 26);
            txtEmpleadoNumeroCalle.TabIndex = 46;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(561, 22);
            label15.Name = "label15";
            label15.Size = new Size(104, 21);
            label15.TabIndex = 45;
            label15.Text = "Numero calle:";
            // 
            // txtEmpleadoCalle
            // 
            txtEmpleadoCalle.Location = new Point(60, 19);
            txtEmpleadoCalle.Name = "txtEmpleadoCalle";
            txtEmpleadoCalle.Size = new Size(449, 26);
            txtEmpleadoCalle.TabIndex = 44;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 22);
            label14.Name = "label14";
            label14.Size = new Size(48, 21);
            label14.TabIndex = 0;
            label14.Text = "Calle:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 262);
            label13.Name = "label13";
            label13.Size = new Size(41, 21);
            label13.TabIndex = 42;
            label13.Text = "RFC:";
            // 
            // txtEmpleadoRFC
            // 
            txtEmpleadoRFC.Location = new Point(10, 286);
            txtEmpleadoRFC.Name = "txtEmpleadoRFC";
            txtEmpleadoRFC.Size = new Size(450, 26);
            txtEmpleadoRFC.TabIndex = 41;
            // 
            // btnEmpleadoCancelar
            // 
            btnEmpleadoCancelar.Cursor = Cursors.Hand;
            btnEmpleadoCancelar.Location = new Point(10, 522);
            btnEmpleadoCancelar.Name = "btnEmpleadoCancelar";
            btnEmpleadoCancelar.Size = new Size(134, 34);
            btnEmpleadoCancelar.TabIndex = 40;
            btnEmpleadoCancelar.Text = "Cancelar";
            btnEmpleadoCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEmpleadoAgregar
            // 
            btnEmpleadoAgregar.Cursor = Cursors.Hand;
            btnEmpleadoAgregar.Location = new Point(803, 522);
            btnEmpleadoAgregar.Name = "btnEmpleadoAgregar";
            btnEmpleadoAgregar.Size = new Size(150, 34);
            btnEmpleadoAgregar.TabIndex = 39;
            btnEmpleadoAgregar.Text = "Agregar empleado";
            btnEmpleadoAgregar.UseVisualStyleBackColor = true;
            // 
            // cbxEmpleadoRol
            // 
            cbxEmpleadoRol.DisplayMember = "SI";
            cbxEmpleadoRol.FormattingEnabled = true;
            cbxEmpleadoRol.Location = new Point(503, 283);
            cbxEmpleadoRol.Name = "cbxEmpleadoRol";
            cbxEmpleadoRol.Size = new Size(449, 29);
            cbxEmpleadoRol.TabIndex = 38;
            cbxEmpleadoRol.Text = "Rol del empleado";
            // 
            // txtEmpleadoCorreo
            // 
            txtEmpleadoCorreo.Location = new Point(9, 226);
            txtEmpleadoCorreo.Name = "txtEmpleadoCorreo";
            txtEmpleadoCorreo.Size = new Size(449, 26);
            txtEmpleadoCorreo.TabIndex = 37;
            // 
            // txtEmpleadoTelefono
            // 
            txtEmpleadoTelefono.Location = new Point(503, 166);
            txtEmpleadoTelefono.Name = "txtEmpleadoTelefono";
            txtEmpleadoTelefono.Size = new Size(450, 26);
            txtEmpleadoTelefono.TabIndex = 36;
            // 
            // txtEmpleadoNombre
            // 
            txtEmpleadoNombre.Location = new Point(9, 166);
            txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            txtEmpleadoNombre.Size = new Size(449, 26);
            txtEmpleadoNombre.TabIndex = 35;
            // 
            // txtEmpleadoApellidoMaterno
            // 
            txtEmpleadoApellidoMaterno.Location = new Point(503, 109);
            txtEmpleadoApellidoMaterno.Name = "txtEmpleadoApellidoMaterno";
            txtEmpleadoApellidoMaterno.Size = new Size(450, 26);
            txtEmpleadoApellidoMaterno.TabIndex = 34;
            // 
            // txtEmpleadoApellidoPaterno
            // 
            txtEmpleadoApellidoPaterno.Location = new Point(9, 109);
            txtEmpleadoApellidoPaterno.Name = "txtEmpleadoApellidoPaterno";
            txtEmpleadoApellidoPaterno.Size = new Size(450, 26);
            txtEmpleadoApellidoPaterno.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(503, 262);
            label12.Name = "label12";
            label12.Size = new Size(36, 21);
            label12.TabIndex = 32;
            label12.Text = "Rol:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 202);
            label11.Name = "label11";
            label11.Size = new Size(134, 21);
            label11.TabIndex = 31;
            label11.Text = "Correo electronico:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(503, 142);
            label10.Name = "label10";
            label10.Size = new Size(72, 21);
            label10.TabIndex = 30;
            label10.Text = "Telefono:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 142);
            label9.Name = "label9";
            label9.Size = new Size(85, 21);
            label9.TabIndex = 29;
            label9.Text = "Nombre(s):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(503, 85);
            label6.Name = "label6";
            label6.Size = new Size(132, 21);
            label6.TabIndex = 28;
            label6.Text = "Apellido materno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 85);
            label5.Name = "label5";
            label5.Size = new Size(127, 21);
            label5.TabIndex = 27;
            label5.Text = "Apellido paterno:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(9, 7);
            label8.Name = "label8";
            label8.Size = new Size(177, 26);
            label8.TabIndex = 13;
            label8.Text = "Agregar empleado";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnEmpleadoEliminar);
            tabPage2.Controls.Add(btnEmpleadoModificar);
            tabPage2.Controls.Add(dgvConsultaCliente);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(962, 571);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEmpleadoEliminar
            // 
            btnEmpleadoEliminar.Cursor = Cursors.Hand;
            btnEmpleadoEliminar.Location = new Point(791, 88);
            btnEmpleadoEliminar.Name = "btnEmpleadoEliminar";
            btnEmpleadoEliminar.Size = new Size(165, 40);
            btnEmpleadoEliminar.TabIndex = 19;
            btnEmpleadoEliminar.Text = "Eliminar";
            btnEmpleadoEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEmpleadoModificar
            // 
            btnEmpleadoModificar.Cursor = Cursors.Hand;
            btnEmpleadoModificar.Location = new Point(791, 42);
            btnEmpleadoModificar.Name = "btnEmpleadoModificar";
            btnEmpleadoModificar.Size = new Size(165, 40);
            btnEmpleadoModificar.TabIndex = 18;
            btnEmpleadoModificar.Text = "Modificar";
            btnEmpleadoModificar.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaCliente
            // 
            dgvConsultaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaCliente.Columns.AddRange(new DataGridViewColumn[] { ApellidoPaterno, ApellidoMaterno, Nombre, Telefono, CorreoElectronico, RFC, Calle, NumeroCalle, Colonia });
            dgvConsultaCliente.Location = new Point(9, 42);
            dgvConsultaCliente.Name = "dgvConsultaCliente";
            dgvConsultaCliente.RowTemplate.Height = 25;
            dgvConsultaCliente.Size = new Size(776, 520);
            dgvConsultaCliente.TabIndex = 15;
            // 
            // ApellidoPaterno
            // 
            ApellidoPaterno.HeaderText = "Apellido paterno";
            ApellidoPaterno.Name = "ApellidoPaterno";
            // 
            // ApellidoMaterno
            // 
            ApellidoMaterno.HeaderText = "Apellido materno";
            ApellidoMaterno.Name = "ApellidoMaterno";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre(s)";
            Nombre.Name = "Nombre";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // CorreoElectronico
            // 
            CorreoElectronico.HeaderText = "Correo electronico";
            CorreoElectronico.Name = "CorreoElectronico";
            // 
            // RFC
            // 
            RFC.HeaderText = "RFC";
            RFC.Name = "RFC";
            // 
            // Calle
            // 
            Calle.HeaderText = "Calle";
            Calle.Name = "Calle";
            // 
            // NumeroCalle
            // 
            NumeroCalle.HeaderText = "Num calle";
            NumeroCalle.Name = "NumeroCalle";
            NumeroCalle.Width = 50;
            // 
            // Colonia
            // 
            Colonia.HeaderText = "Colonia";
            Colonia.Name = "Colonia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 7);
            label4.Name = "label4";
            label4.Size = new Size(217, 26);
            label4.TabIndex = 14;
            label4.Text = "Empleados registrados";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(503, 202);
            label17.Name = "label17";
            label17.Size = new Size(92, 21);
            label17.TabIndex = 44;
            label17.Text = "Contraseña:";
            // 
            // txtEmpleadoContraseña
            // 
            txtEmpleadoContraseña.Location = new Point(503, 226);
            txtEmpleadoContraseña.Name = "txtEmpleadoContraseña";
            txtEmpleadoContraseña.Size = new Size(449, 26);
            txtEmpleadoContraseña.TabIndex = 45;
            // 
            // employee
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
            Name = "employee";
            Text = "Espresso Esencial - Empleado";
            Load += employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            gpxDireccion.ResumeLayout(false);
            gpxDireccion.PerformLayout();
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
        private LinkLabel lnkProducto;
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
        private LinkLabel lnkIngrediente;
        private Label label7;
        private Label lblEmpleado;
        private Label label8;
        private Label label4;
        private Button btnEmpleadoCancelar;
        private Button btnEmpleadoAgregar;
        private ComboBox cbxEmpleadoRol;
        private TextBox txtEmpleadoCorreo;
        private TextBox txtEmpleadoTelefono;
        private TextBox txtEmpleadoNombre;
        private TextBox txtEmpleadoApellidoMaterno;
        private TextBox txtEmpleadoApellidoPaterno;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label6;
        private Label label5;
        private GroupBox gpxDireccion;
        private TextBox txtEmpleadoNumeroCalle;
        private Label label15;
        private TextBox txtEmpleadoCalle;
        private Label label14;
        private Label label13;
        private TextBox txtEmpleadoRFC;
        private TextBox txtEmpleadoColonia;
        private Label label16;
        private DataGridView dgvConsultaCliente;
        private Button btnEmpleadoEliminar;
        private Button btnEmpleadoModificar;
        private DataGridViewTextBoxColumn ApellidoPaterno;
        private DataGridViewTextBoxColumn ApellidoMaterno;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn CorreoElectronico;
        private DataGridViewTextBoxColumn RFC;
        private DataGridViewTextBoxColumn Calle;
        private DataGridViewTextBoxColumn NumeroCalle;
        private DataGridViewTextBoxColumn Colonia;
        private TextBox txtEmpleadoContraseña;
        private Label label17;
    }
}