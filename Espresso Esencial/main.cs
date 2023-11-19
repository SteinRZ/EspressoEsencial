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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            order order = new order();
            order.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            product product = new product();
            product.Show();
            this.Hide();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            employee employee = new employee();
            employee.Show();
            this.Hide();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            category category = new category();
            category.Show();
            this.Hide();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            supplier supplier = new supplier();
            supplier.Show();
            this.Hide();
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            client client = new client();
            client.Show();
            this.Hide();
        }

        private void btnIngrediente_Click(object sender, EventArgs e)
        {
            ingredient ingredient = new ingredient();
            ingredient.Show();
            this.Close();
        }
    }
}
