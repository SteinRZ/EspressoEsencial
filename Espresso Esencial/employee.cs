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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
            dgvConsultaEmpleado.Name = "Empleado";
            dgvConsultaEmpleado.CellValueChanged += SystemUtils.GenericUpdate;
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

        private void employee_Load(object sender, EventArgs e)
        {

        }

        private void lnkIngrediente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ingredient ingredient = new ingredient();
            ingredient.Show();
            this.Close();
        }

        private void btnEmpleadoAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand insert = new SqlCommand("INSERT INTO Empleado(Apellido_Paterno, Apellido_Materno, Nombre, Telefono, Correo, RFC, Calle, Numero_Calle, Colonia) VALUES(@aPaterno, @aMaterno, @nombre, @tel, @email, @rfc, @calle, @numCalle, @colonia)"))
                {
                    insert.Connection = SystemUtils.Connection;
                    insert.Parameters.Add("@aPaterno", SqlDbType.VarChar, 30).Value = txtEmpleadoApellidoPaterno.Text;
                    insert.Parameters.Add("@aMaterno", SqlDbType.VarChar, 30).Value = txtEmpleadoApellidoMaterno.Text;
                    insert.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = txtEmpleadoNombre.Text;
                    insert.Parameters.Add("@tel", SqlDbType.Char, 10).Value = txtEmpleadoTelefono.Text;
                    insert.Parameters.Add("@email", SqlDbType.VarChar, 30).Value = txtEmpleadoCorreo.Text;
                    insert.Parameters.Add("@rfc", SqlDbType.Char, 10).Value = txtEmpleadoRFC.Text;
                    insert.Parameters.Add("@calle", SqlDbType.VarChar, 30).Value = txtEmpleadoCalle.Text;
                    insert.Parameters.Add("@numCalle", SqlDbType.Int).Value = int.Parse(txtEmpleadoNumeroCalle.Text);
                    insert.Parameters.Add("@colonia", SqlDbType.VarChar, 30).Value = txtEmpleadoColonia.Text;
                    insert.ExecuteNonQuery();
                }
                MessageBox.Show("Se insertó el empleado correctamente.");
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
                using (IDataReader data = SystemUtils.MakeQuery("SELECT * FROM Empleado"))
                {
                    if (data != null)
                    {
                        dgvConsultaEmpleado.Rows.Clear();
                        while (data.Read())
                        {
                            dgvConsultaEmpleado.Rows.Add(
                                data["Apellido_Paterno"],
                                data["Apellido_Materno"],
                                data["Nombre"],
                                data["Telefono"],
                                data["Correo"],
                                data["RFC"],
                                data["Calle"],
                                data["Numero_Calle"],
                                data["Colonia"]);
                        }
                    }
                }*/
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM Empleado");
                command.Connection = SystemUtils.Connection;
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                dgvConsultaEmpleado.DataSource = dt;
                dgvConsultaEmpleado.Columns[0].Visible = false;
            }
        }

        private void btnEmpleadoEliminar_Click(object sender, EventArgs e)
        {
            SystemUtils.DeleteFromTable(ref dgvConsultaEmpleado);
        }
    }
}
