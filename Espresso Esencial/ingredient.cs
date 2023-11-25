using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
