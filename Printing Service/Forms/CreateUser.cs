using BL.Base;
using BL.Objects;

namespace Printing_Service.Forms
{
    public partial class CreateUser : Form
    {
        DBase _db;
        User _user = new User();
        public CreateUser(DBase db)
        {
            InitializeComponent();

            _db = db;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username is empty!");
                return;
            }
            else if (txtUsername.Text.Length < 5)
            {
                MessageBox.Show("The length of the username must contain at least 5 characters!");
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is empty!");
                return;
            }
            else if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("The password must contain at least 8 characters!");
                return;
            }
            else
            {
                _user.Username = txtUsername.Text;
                _user.Password = txtPassword.Text;
                _user.Role = comboRole.SelectedItem?.ToString() ?? "Unknown";

                if (_db.Users.Where(x => x.Username == txtUsername.Text).Count() == 0)
                {
                    _db.Users.Add(_user);
                    _db.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This user already available!");
                }
            }
        }
    }
}
