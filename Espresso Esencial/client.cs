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
using System.Xml.Linq;

namespace Espresso_Esencial
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
            dgvConsultaCliente.Name = "Cliente";
            dgvConsultaCliente.CellValueChanged += SystemUtils.GenericUpdate;
            lblEmpleado.Text = SystemUtils.Username;
        }

        private void client_Load(object sender, EventArgs e)
        {

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

        private void btnClienteAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand insert = new SqlCommand("INSERT INTO Cliente(Apellido_Paterno, Apellido_Materno, Nombre, Telefono, Correo, Estudiante) VALUES(@aPaterno, @aMaterno, @nombre, @tel, @email, @estudiante)"))
                {
                    insert.Connection = SystemUtils.Connection;
                    insert.Parameters.Add("@aPaterno", SqlDbType.VarChar, 30).Value = txtClienteApellidoPaterno.Text;
                    insert.Parameters.Add("@aMaterno", SqlDbType.VarChar, 30).Value = txtClienteApellidoMaterno.Text;
                    insert.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = txtClienteNombre.Text;
                    insert.Parameters.Add("@tel", SqlDbType.Char, 10).Value = txtClienteTelefono.Text;
                    insert.Parameters.Add("@email", SqlDbType.VarChar, 30).Value = txtClienteCorreo.Text;
                    insert.Parameters.Add("@estudiante", SqlDbType.Char, 3).Value = chkEstudiante.Checked ? "Si" : "No";
                    insert.ExecuteNonQuery();
                }
                MessageBox.Show("Se insertó el cliente correctamente.");
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
                /*dgvConsultaCliente.Rows.Clear();
                using (IDataReader data = SystemUtils.MakeQuery("SELECT * FROM Cliente"))
                {
                    while (data.Read())
                    {
                        dgvConsultaCliente.Rows.Add(
                            data["ID_Cliente"],
                            data["Apellido_Paterno"],
                            data["Apellido_Materno"],
                            data["Nombre"],
                            data["Telefono"],
                            data["Correo"],
                            data["Puntos"],
                            data["Estudiante"]
                        );
                    }
                }*/
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM Cliente");
                command.Connection = SystemUtils.Connection;
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                dgvConsultaCliente.DataSource = dt;
                dgvConsultaCliente.Columns[0].Visible = false;
            }
        }

        private void dgvConsultaCliente_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void btnClienteEliminar_Click(object sender, EventArgs e)
        {
            SystemUtils.DeleteFromTable(ref dgvConsultaCliente);
        }

        /*private void dgvConsultaCliente_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            //string oldValue = (string)grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            try
            {
                using (SqlCommand update = new SqlCommand($"UPDATE Cliente SET {grid.Columns[e.ColumnIndex].Name} = @valor WHERE ID_Cliente = @id"))
                {
                    update.Connection = SystemUtils.Connection;
                    update.Parameters.AddWithValue("@valor", grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    update.Parameters.AddWithValue("@id", grid.Rows[e.RowIndex].Cells[0].Value);
                    if (MessageBox.Show("¿Estás seguro de cambiar el registro?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        DataTable dt = grid.DataSource as DataTable;
                        dt.RejectChanges();
                        return;
                    }
                    update.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}
