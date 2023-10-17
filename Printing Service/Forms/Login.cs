using BL.Base;
using BL.Objects;
using Printing_Service.Factory;

namespace Printing_Service.Forms
{
    public partial class Login : Form
    {
        private readonly IAdminFactory _adminFactory;
        private readonly DBase _db;
        private User? _user;

        private const string serviceUser = "Service";
        private const string servicePassword = "QWE123rty456";

        public Login(IAdminFactory adminFactory, DBase db)
        {
            InitializeComponent();

            _adminFactory = adminFactory;
            _db = db;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _user = _db.Users.FirstOrDefault(x => x.Username == txtUsername.Text & x.Password == txtPassword.Text);

            if (_user?.Role == "Admin")
            {
                txtUsername.Clear();
                txtPassword.Clear();
                _adminFactory.Create().ShowDialog();
            }
            else if (txtUsername.Text == serviceUser && txtPassword.Text == servicePassword)
            {
                txtUsername.Clear();
                txtPassword.Clear();
                _adminFactory.Create().ShowDialog();
            }
            else
            {
                MessageBox.Show("Authorization failed.\nPlease contact your Administrator!");
            }
        }
    }
}
