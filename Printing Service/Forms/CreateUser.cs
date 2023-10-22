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

            KeyDown += CreateUser_KeyDown;
        }

        private void CreateUser_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: btnSave_Click(sender, e); break; //Enter saves user
                case Keys.Escape: btnCancel_Click(sender, e); break; //Escape cancel operation
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Check steps for User creation
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username is empty!");
                return; //next instruction of code ignored, we go out from this method
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
                //Prepare User object for save to base
                _user.Username = txtUsername.Text;
                _user.Password = txtPassword.Text;
                _user.Role = comboRole.SelectedItem?.ToString() ?? "Unknown";

                //Checks User already not included in base
                if (_db.Users.Where(x => x.Username == txtUsername.Text).Count() == 0) //Linq = SQL 
                {
                    _db.Users.Add(_user);
                    _db.SaveChanges();

                    this.DialogResult = DialogResult.OK; //return OK answer, after save operation is sucessfull
                    this.Close(); //close this form
                }
                else
                {
                    MessageBox.Show("This user already available!");
                }
            }
        }
    }
}
