namespace Espresso_Esencial
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            lblError.Text = String.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string error;
            if (!SystemUtils.ConnectToDatabase(txtUsername.Text, txtContraseña.Text, out error))
            {
                lblError.Text = error;
                return;
            }
            main main = new main();
            main.Show();
            this.Hide();
        }
    }
}
