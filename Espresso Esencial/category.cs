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
    public partial class category : Form
    {
        public category()
        {
            InitializeComponent();
            dgvCategoriaConsultar.Name = "Categoria";
            dgvCategoriaConsultar.CellValueChanged += SystemUtils.GenericUpdate;
            ReloadDGV();
        }

        private void ReloadDGV()
        {
            /*
            dgvCategoriaConsultar.Rows.Clear();
            using (IDataReader data = SystemUtils.MakeQuery("SELECT * FROM Categoria"))
            {
                if (data != null)
                {
                    while (data.Read())
                    {
                        dgvCategoriaConsultar.Rows.Add(
                            data["Nombre"],
                            data["Descripcion"]
                            );
                    }
                }
            }
            */
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Categoria");
            command.Connection = SystemUtils.Connection;
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            dgvCategoriaConsultar.DataSource = dt;
            dgvCategoriaConsultar.Columns[0].Visible = false;
        }

        private void lnkInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            main main = new main();
            main.Show();
            this.Close();
        }

        private void lnkPedido_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void btnCategoriaAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand insert = new SqlCommand("INSERT INTO Categoria(Nombre, Descripcion) VALUES(@nombre, @descripcion)"))
                {
                    insert.Connection = SystemUtils.Connection;
                    insert.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = txtCategoriaNombre.Text.ToUpper();
                    insert.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = txtCategoriaDescripcion.Text.ToUpper();
                    insert.ExecuteNonQuery();
                }
                MessageBox.Show("Se insertó la categoria correctamente.");
                ReloadDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClienteEliminar_Click(object sender, EventArgs e)
        {
            SystemUtils.DeleteFromTable(ref dgvCategoriaConsultar);
        }
    }
}
