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
                dgvConsultaCliente.Rows.Clear();
                using (IDataReader data = SystemUtils.MakeQuery("SELECT * FROM Cliente"))
                {
                    while (data.Read())
                    {
                        dgvConsultaCliente.Rows.Add(
                            data["Apellido_Paterno"],
                            data["Apellido_Materno"],
                            data["Nombre"],
                            data["Telefono"],
                            data["Correo"],
                            data["Puntos"],
                            data["Estudiante"]
                        );
                    }
                }
            }
        }


    }
}
