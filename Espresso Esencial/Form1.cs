namespace Espresso_Esencial
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            this.Hide();
        }
    }
}