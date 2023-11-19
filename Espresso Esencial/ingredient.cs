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
