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
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
            dgvProveedorConsultar.Name = "Proveedor";
            dgvProveedorConsultar.CellValueChanged += SystemUtils.GenericUpdate;
            ReloadDGV();
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

        private void lnkIngrediente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ingredient ingredient = new ingredient();
            ingredient.Show();
            this.Close();
        }
        private void ReloadDGV()
        {
            /*
            dgvProveedorConsultar.Rows.Clear();
            using (IDataReader data = SystemUtils.MakeQuery("SELECT * FROM Proveedor"))
            {
                if (data != null)
                {
                    while (data.Read())
                    {
                        dgvProveedorConsultar.Rows.Add(
                            data["Nombre"],
                            data["Telefono"]
                            );
                    }
                }
            }
            */
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Proveedor");
            command.Connection = SystemUtils.Connection;
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            dgvProveedorConsultar.DataSource = dt;
            dgvProveedorConsultar.Columns[0].Visible = false;
        }
        private void btnProveedorAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand insert = new SqlCommand("INSERT INTO Proveedor(Nombre, Telefono) VALUES(@nombre, @telefono)"))
                {
                    insert.Connection = SystemUtils.Connection;
                    insert.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = txtProveedorNombre.Text;
                    insert.Parameters.Add("@telefono", SqlDbType.Char, 10).Value = txtProveedorTelefono.Text;
                    insert.ExecuteNonQuery();
                }
                MessageBox.Show("Se insertó el proveedor correctamente.");
                ReloadDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProveedorEliminar_Click(object sender, EventArgs e)
        {
            SystemUtils.DeleteFromTable(ref dgvProveedorConsultar);
        }
    }
}
