namespace HOTEL_LOGIN
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtRegister_Click(object sender, EventArgs e)
        {
            new formSIGNUP().Show();
            this.Hide();
        }
    }
}
