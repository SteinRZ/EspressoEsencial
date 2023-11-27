using Microsoft.VisualBasic;
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
    public partial class ingredient : Form
    {
        public ingredient()
        {
            InitializeComponent();
            dgvConsultaCliente.Name = "Ingrediente";
            dgvConsultaCliente.CellValueChanged += SystemUtils.GenericUpdate;
            using (IDataReader proveedorInfo = SystemUtils.MakeQuery("SELECT Nombre FROM Proveedor"))
            {
                if (proveedorInfo != null)
                {
                    while (proveedorInfo.Read())
                    {
                        cbxIngredienteProveedor.Items.Add(proveedorInfo["Nombre"]);
                    }
                }
            }
        }

        private void lnkProveedor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            supplier supplier = new supplier();
            supplier.Show();
            this.Close();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngredienteAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    using (SqlCommand insert = new SqlCommand("INSERT INTO Ingrediente(Nombre, ID_Proveedor, Cantidad_Actual, Cantidad_Minima, Caducidad)" +
                        " VALUES(@nombre, @idProv, @cActual, @cMinima, @caducidad)"))
                    {
                        insert.Connection = SystemUtils.Connection;
                        using (IDataReader d = SystemUtils.MakeQuery($"SELECT ID_Proveedor FROM Proveedor WHERE Nombre = '{cbxIngredienteProveedor.Text}'"))
                        {
                            if (d.Read())
                                insert.Parameters.Add("@idProv", SqlDbType.Int).Value = d["ID_Proveedor"];
                            else
                                throw new ArgumentOutOfRangeException();
                        }
                        insert.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = txtIngredienteNombre.Text;
                        insert.Parameters.Add("@cActual", SqlDbType.Int).Value = int.Parse(txtIngredienteCantidadActual.Text);
                        insert.Parameters.Add("@cMinima", SqlDbType.Int).Value = int.Parse(txtIngredienteCantidadMinima.Text);
                        insert.Parameters.Add("@caducidad", SqlDbType.Date).Value = dtpIngredienteCaducidad.Value;
                        insert.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se insertó el ingrediente correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                dgvConsultaCliente.Rows.Clear();
                using (IDataReader data = SystemUtils.MakeQuery("SELECT I.Nombre, P.Nombre as Proveedor, I.Cantidad_Actual, I.Cantidad_Minima, I.Caducidad FROM INGREDIENTE I LEFT JOIN PROVEEDOR P ON I.ID_PROVEEDOR = P.ID_PROVEEDOR"))
                {
                    if (data != null)
                    {
                        while (data.Read())
                        {
                            dgvConsultaCliente.Rows.Add(
                                data["Nombre"],
                                data["Proveedor"],
                                data["Cantidad_Actual"],
                                data["Cantidad_Minima"],
                                data["Caducidad"]);
                        }
                    }
                }*/
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM Ingrediente");
                command.Connection = SystemUtils.Connection;
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                dgvConsultaCliente.DataSource = dt;
                dgvConsultaCliente.Columns[0].Visible = false;
            }
        }

        private void btnIngredienteEliminar_Click(object sender, EventArgs e)
        {
            SystemUtils.DeleteFromTable(ref dgvConsultaCliente);
        }
    }
}
