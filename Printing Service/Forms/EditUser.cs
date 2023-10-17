using BL.Base;
using BL.Objects;

namespace Printing_Service.Forms
{
    public partial class EditUser : Form
    {
        DBase _db;
        User _user;
        public EditUser(DBase db, User user)
        {
            InitializeComponent();

            _db = db;
            _user = user;

            Load += EditUser_Load;
        }

        private void EditUser_Load(object? sender, EventArgs e)
        {
            txtUsername.Text = _user.Username;
            txtPassword.Text = _user.Password;
            comboRole.Text = _user.Role;
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

                _db.Users.Update(_user);
                _db.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
