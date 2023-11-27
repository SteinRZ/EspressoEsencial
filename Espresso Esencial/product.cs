using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espresso_Esencial
{
    public partial class product : Form
    {
        private struct Ingredient
        {
            public string Nombre { get; set; }
            public float Cantidad { get; set; }
            public Ingredient(string nombre, float cantidad)
            {
                Nombre = nombre;
                Cantidad = cantidad;
            }
        }
        private BindingList<Ingredient> ingredients;
        private BindingSource source;
        public product()
        {
            InitializeComponent();
            dgvConsultaProducto.Name = "Producto";
            dgvConsultaProducto.CellValueChanged += SystemUtils.GenericUpdate;
            dgvIngredientes.AutoGenerateColumns = true;
            ingredients = new BindingList<Ingredient>();
            source = new BindingSource(ingredients, null);
            dgvIngredientes.DataSource = source;
            using (IDataReader productCategory = SystemUtils.MakeQuery("SELECT Nombre FROM Categoria"))
            {
                while (productCategory.Read())
                {
                    cbxProductoCategoria.Items.Add(productCategory["Nombre"]);
                }
            }
            using (IDataReader ingredientList = SystemUtils.MakeQuery("SELECT Nombre FROM Ingrediente"))
            {
                while (ingredientList.Read())
                {
                    cbxProductoIngrediente.Items.Add(ingredientList["Nombre"]);
                }
            }
        }

        private void lnkInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            main main = new main();
            main.Show();
            this.Close();
        }

        private void lnkPedido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            order order = new order();
            order.Show();
            this.Close();
        }

        private void lnkCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            client client = new client();
            client.Show();
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

        private void btnProductoAgregaIngrediente_Click(object sender, EventArgs e)
        {
            string nombre = cbxProductoIngrediente.Text;
            if (nombre == String.Empty)
            {
                MessageBox.Show("No hay ingrediente seleccionado");
                return;
            }
            if (ingredients.Where(elem => elem.Nombre == nombre).ToList().Count >= 1)
            {
                MessageBox.Show("Ya está ingresado ese ingrediente");
                return;
            }
            try
            {
                ingredients.Add(new Ingredient(cbxProductoIngrediente.Text, float.Parse(txtProductoCantidadNecesariaIngrediente.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProductoAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int lastInsertedId;
                using (SqlCommand insert = new SqlCommand("INSERT INTO Producto(ID_Categoria, Nombre, Descripcion, Precio, Cantidad_Actual, Cantidad_Minima) OUTPUT INSERTED.ID_Producto VALUES(@categoria, @nombre, @desc, @precio, @cActual, @cMinima)"))
                {
                    insert.Connection = SystemUtils.Connection;
                    using (IDataReader d = SystemUtils.MakeQuery($"SELECT ID_Categoria FROM Categoria WHERE Nombre = '{cbxProductoCategoria.Text}'"))
                    {
                        if (d.Read())
                            insert.Parameters.Add("@categoria", SqlDbType.Int).Value = d["ID_Categoria"];
                        else
                            throw new ArgumentOutOfRangeException();
                    }
                    insert.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = txtNombreProducto.Text;
                    insert.Parameters.Add("@desc", SqlDbType.VarChar, 30).Value = txtDescripcionProducto.Text;
                    insert.Parameters.Add("@precio", SqlDbType.Float).Value = float.Parse(txtPrecioProducto.Text);
                    insert.Parameters.Add("@cActual", SqlDbType.Int).Value = int.Parse(txtProductoCantidadActual.Text);
                    insert.Parameters.Add("@cMinima", SqlDbType.Int).Value = int.Parse(txtProductoCantidadMinima.Text);
                    lastInsertedId = (int)insert.ExecuteScalar();

                    insert.CommandText = "INSERT INTO Producto_Ingrediente(ID_Ingrediente, ID_Producto, Cantidad_Necesaria) VALUES(@idIng, @idPro, @cant)";
                    insert.Parameters.Clear();
                    insert.Parameters.Add("@idIng", SqlDbType.Int);
                    insert.Parameters.Add("@idPro", SqlDbType.Int);
                    insert.Parameters.Add("@cant", SqlDbType.Float);
                    foreach (var ing in ingredients)
                    {
                        using (IDataReader d = SystemUtils.MakeQuery($"SELECT ID_Ingrediente FROM Ingrediente WHERE Nombre = '{ing.Nombre}'"))
                        {
                            d.Read();
                            insert.Parameters[0].Value = d.GetInt32(0);
                        }
                        insert.Parameters[1].Value = lastInsertedId;
                        insert.Parameters[2].Value = ing.Cantidad;
                        insert.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Se insertó el producto correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if (current.Text == "Consultar")
            {
                /*
                dgvConsultaProducto.Rows.Clear();
                using (IDataReader data = SystemUtils.MakeQuery("SELECT * FROM Producto"))
                {
                    if (data != null)
                    {
                        while (data.Read())
                        {
                            dgvConsultaProducto.Rows.Add(
                                data["ID_Producto"],
                                data["Nombre"],
                                data["Descripcion"],
                                data["Precio"],
                                data["Cantidad_Actual"],
                                data["Cantidad_Minima"]
                                );
                        }
                    }
                }
                */
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM Producto");
                command.Connection = SystemUtils.Connection;
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                dgvConsultaProducto.DataSource = dt;
                dgvConsultaProducto.Columns[0].Visible = false;
            }
        }

        private void btnProductoConsultar_Click(object sender, EventArgs e)
        {
            string id = dgvConsultaProducto.CurrentRow.Cells["ID_Producto"].Value.ToString();
            using (IDataReader d = SystemUtils.MakeQuery($"SELECT I.Nombre, PI.Cantidad_Necesaria FROM Producto_Ingrediente PI LEFT JOIN Ingrediente I ON PI.ID_Ingrediente = I.ID_Ingrediente WHERE ID_Producto = {id}"))
            {
                string ingredients = String.Empty;
                int cnt = 0;
                while (d.Read())
                {
                    ingredients += $"({cnt++}): [Nombre: {d.GetString(0)}, Cantidad: {d.GetDouble(1)}]\r\n";
                }
                if (ingredients == String.Empty) ingredients = "No hay ingredientes asociados con el producto.";
                MessageBox.Show(ingredients);
            }
        }

        private void btnProductoEliminar_Click(object sender, EventArgs e)
        {
            SystemUtils.DeleteFromTable(ref dgvConsultaProducto);
        }
    }
}
