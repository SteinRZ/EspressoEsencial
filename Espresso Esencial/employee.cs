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
            using (IDataReader data = SystemUtils.MakeQuery("SELECT * FROM Empleado"))
            {
                if (data != null)
                {
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

        }
    }
}
