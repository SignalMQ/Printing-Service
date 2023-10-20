using BL.Base;
using BL.Objects;
using Printing_Service.Factory;

namespace Printing_Service.Forms
{
    public partial class Login : Form
    {
        private readonly IAdminFactory _adminFactory;
        private readonly ICustomerFactory _customerFactory;
        private readonly DBase _db;
        private User? _user;

        private const string serviceUser = "Service";
        private const string servicePassword = "QWE123rty456";

        public Login(IAdminFactory adminFactory, ICustomerFactory customerFactory, DBase db)
        {
            InitializeComponent();

            _adminFactory = adminFactory;
            _customerFactory = customerFactory;
            _db = db;

            KeyDown += Login_KeyDown;
        }

        private void Login_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: btnLogin_Click(sender, e); break;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _user = _db.Users.FirstOrDefault(x => x.Username == txtUsername.Text & x.Password == txtPassword.Text);

            //Service account
            if (txtUsername.Text == serviceUser && txtPassword.Text == servicePassword)
            {
                _adminFactory.Create().ShowDialog();
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                return;
            }

            //Easy routing
            switch (_user?.Role)
            {
                case "Admin":
                    {
                        _adminFactory.Create().ShowDialog();
                        txtUsername.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                    };
                    break;
                case "Customer":
                    {
                        _customerFactory.Create(_user).ShowDialog();
                        txtUsername.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                    }
                    break;
                default: 
                    {
                        MessageBox.Show("Authorization failed.\nPlease contact your Administrator!");
                        txtUsername.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                    }
                    break;
            }
        }
    }
}
