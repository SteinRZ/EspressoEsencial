using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espresso_Esencial
{
    public partial class order : Form
    {
        private List<Button> espressoButtons;
        private int Margen { get; } = 10;
        private Size ButtonSize { get; } = new Size(100, 100);
        private class DetallePedido
        {
            [System.ComponentModel.Browsable(false)]
            public int ID { get; set; }
            public string Producto { get; set; }
            public double Precio { get; set; }
            public int Cantidad { get; set; }
            public double Total
            {
                get
                {
                    return Precio * Cantidad;
                }
            }
            public DetallePedido(int id, string producto, double precio)
            {
                ID = id;
                Producto = producto;
                Precio = precio;
                Cantidad = 1;
            }
        }
        private BindingList<DetallePedido> details;
        private BindingSource source;
        public order()
        {
            InitializeComponent();
            dgvConsultaPedido.Name = "Pedido";
            dgvConsultaPedido.CellValueChanged += SystemUtils.GenericUpdate;
            dgvListaPedido.AutoGenerateColumns = true;
            details = new BindingList<DetallePedido>();
            source = new BindingSource(details, null);
            dgvListaPedido.DataSource = source;
            try
            {
                using (IDataReader categoria = SystemUtils.MakeQuery("SELECT Nombre FROM Categoria"))
                {
                    if (categoria == null)
                        throw new SqlNullValueException();
                    while (categoria.Read())
                    {
                        tabProductos.TabPages.Add(new TabPage { Text = categoria.GetString(0) });
                    }
                }
                foreach (TabPage tab in tabProductos.TabPages)
                {
                    using (IDataReader data = SystemUtils.MakeQuery($"SELECT P.ID_Producto, P.Nombre, P.Precio FROM Producto P LEFT JOIN Categoria C ON C.ID_Categoria = P.ID_Categoria WHERE C.Nombre = '{tab.Text}'"))
                    {
                        int curr = 0;
                        if (data == null)
                            throw new SqlNullValueException();
                        while (data.Read())
                        {
                            Point p = new Point();
                            p.X = Margen * ((curr % 5) + 1) + ButtonSize.Width * (curr % 5);
                            p.Y = Margen * ((curr / 5) + 1) + ButtonSize.Height * (curr / 5);
                            Button btn = new Button()
                            {
                                Size = ButtonSize,
                                Location = p,
                                Text = data.GetString(1),
                                Name = data.GetInt32(0).ToString()
                            };
                            btn.Click += GenericButtonClick;
                            tab.Controls.Add(btn);
                            curr++;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Order_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lnkInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            main main = new main();
            main.Show();
            this.Close();
        }

        private void lnkCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            client client = new client();
            client.Show();
            this.Close();
        }

        private void lnkProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            product product = new product();
            product.Show();
            this.Close();
        }

        private void lnkEmpleado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            employee employee = new employee();
            employee.Show();
            this.Close();
        }

        private void lnkCategoria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            category category = new category();
            category.Show();
            this.Close();
        }

        private void lnkProveedor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            supplier supplier = new supplier();
            supplier.Show();
            this.Close();
        }

        private void lnkIngrediente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ingredient ingredient = new ingredient();
            ingredient.Show();
            this.Close();
        }

        private void GenericButtonClick(object sender, EventArgs e)
        {
            int d = details.ToList().FindIndex(b => b.ID.ToString() == (sender as Button).Name);
            if (d == -1)
            {
                using (IDataReader data = SystemUtils.MakeQuery($"SELECT Precio FROM Producto WHERE ID_Producto = '{(sender as Button).Name}'"))
                {
                    data.Read();
                    details.Add(new DetallePedido(int.Parse((sender as Button).Name), (sender as Button).Text, data.GetDouble(0)));
                }
            }
            else
            {
                details[d].Cantidad++;
            }
            source.ResetBindings(false);
            lblTotal.Text = details.Sum(b => b.Total).ToString("C2");
        }

        private void btnPedidoRealizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (details.Count == 0)
                {
                    MessageBox.Show("No hay productos en la orden");
                    return;
                }
                int pedidoId;
                using (SqlCommand insert = new SqlCommand("INSERT INTO Pedido(ID_Empleado, Fecha, Total)  VALUES(@empleado, @fecha, @total); SELECT SCOPE_IDENTITY();"))
                {
                    insert.Connection = SystemUtils.Connection;
                    insert.Parameters.Add("@fecha", SqlDbType.Date).Value = DateTime.Now;
                    insert.Parameters.Add("@empleado", SqlDbType.Int).Value = 2;
                    insert.Parameters.Add("@total", SqlDbType.Money).Value = details.Sum(elem => elem.Total);
                    pedidoId = Convert.ToInt32(insert.ExecuteScalar());
                }
                foreach (DetallePedido pedido in details)
                {
                    using (SqlCommand insert = new SqlCommand("INSERT INTO Detalle_Pedido(ID_Pedido, ID_Producto, Cantidad) VALUES(@idPedido, @idPro, @cant)"))
                    {
                        insert.Connection = SystemUtils.Connection;
                        insert.Parameters.Add("@idPedido", SqlDbType.Int).Value = pedidoId;
                        insert.Parameters.Add("@idPro", SqlDbType.Int).Value = pedido.ID;
                        insert.Parameters.Add("@cant", SqlDbType.Int).Value = pedido.Cantidad;
                        insert.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se insertó el pedido correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabAgregarConsultar_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if (current.Text == "Consultar")
            {
                /*
                dgvConsultaPedido.Rows.Clear();
                using (IDataReader data = SystemUtils.MakeQuery("SELECT * FROM Pedido"))
                {
                    if (data != null)
                    {
                        while (data.Read())
                        {
                            dgvConsultaPedido.Rows.Add(
                                data["ID_Pedido"],
                                data["ID_Empleado"],
                                data["ID_Cliente"],
                                data["Fecha"],
                                Convert.ToDouble(data["Total"]).ToString("C2")
                                );
                        }
                    }
                }
                */
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM Pedido");
                command.Connection = SystemUtils.Connection;
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                dgvConsultaPedido.DataSource = dt;
                dgvConsultaPedido.Columns[0].Visible = false;
            }
        }

        private void btnPedidoConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvConsultaPedido.CurrentRow.Cells["ID_Pedido"].Value.ToString();
                using (IDataReader data = SystemUtils.MakeQuery($"SELECT P.Nombre, D.Cantidad FROM Detalle_Pedido D LEFT JOIN Producto P ON D.ID_Producto = P.ID_Producto WHERE D.ID_Pedido = '{id}'"))
                {
                    string productos = String.Empty;
                    int cnt = 0;
                    while (data.Read())
                    {
                        productos += $"({cnt++}): [Nombre: {data.GetString(0)}, Cantidad: {data.GetInt32(1)}]\r\n";
                    }
                    MessageBox.Show(productos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPedidoCancelar_Click(object sender, EventArgs e)
        {
            details.Clear();
        }

        private void btnPedidoEliminar_Click(object sender, EventArgs e)
        {
            SystemUtils.DeleteFromTable(ref dgvConsultaPedido);
        }
    }
}
