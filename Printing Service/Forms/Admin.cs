using BL.Base;
using BL.Objects;
using Printing_Service.Factory;

namespace Printing_Service.Forms
{
    public partial class Admin : Form
    {
        // private and readonly used for code security reasons

        private List<User> _users = new List<User>();
        private List<Request> _requests = new List<Request>();
        private readonly ICreateUserFactory _createUserFactory;
        private readonly IEditUserFactory _editUserFactory;
        private readonly DBase _db;
        public Admin(ICreateUserFactory createUserFactory, IEditUserFactory editUserFactory, DBase db) //objects saved from AdminFactory
        {
            InitializeComponent();

            _createUserFactory = createUserFactory; // interface = realization
            _editUserFactory = editUserFactory;
            _db = db;

            Load += Admin_Load; //this executes when form shows
            KeyDown += Admin_KeyDown; //this executes when user press some keys in keyboard
        }

        private void Admin_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode) //recognise what key are pressed?
            {
                case Keys.Escape: btnExit_Click(sender, e); break; //escape pressed, and executes btnExit events
            }
        }

        private void Admin_Load(object? sender, EventArgs e)
        {
            LoadTable();
        }

        /// <summary>
        /// Load table data for showing in data grid
        /// </summary>
        private void LoadTable()
        {
            _users = _db.Users.ToList();
            usersTable.DataSource = _users;
            if (_users.Count > 0)
            {
                LoadRequests(_users[usersTable.CurrentCell.RowIndex]);
            }
        }

        /// <summary>
        /// Load users from base
        /// </summary>
        /// <param name="user"></param>
        private void LoadRequests(User user)
        {
            _requests.Clear();

            foreach (Request request in _db.Requests.Where(x => x.UserId == user.Id))
            {
                _requests.Add(request);
            }

            requestsTable.DataSource = _requests.Count > 0 ? _requests : null;
        }

        /// <summary>
        /// Execute CreateUser form for make the User in base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createUserItem_Click(object sender, EventArgs e)
        {
            var createUser = _createUserFactory.Create();
            var result = createUser.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                LoadTable(); //update table, if received OK answer from the create form!
            }
        }

        /// <summary>
        /// Edit User from base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usersTable.Rows.Count > 0)
            {
                var selectedIndex = usersTable.CurrentCell.RowIndex;
                var user = _users[selectedIndex];
                var editUser = _editUserFactory.Create(user);
                var result = editUser.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    LoadTable();
                }
            }
        }

        /// <summary>
        /// Update table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTable();
            usersTable.Update();
        }

        /// <summary>
        /// Exit from this forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Load requests for selected user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedIndex = usersTable.CurrentCell.RowIndex;
            var user = _users[selectedIndex];
            LoadRequests(user);
        }

        /// <summary>
        /// Remove user from base, deletes more users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usersTable.Rows.Count > 0)
            {
                if (MessageBox.Show("Do you really want to do this?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) //confirmation before delete
                {
                    foreach (var index in usersTable.SelectedCells.Cast<DataGridViewCell>() //select users from base and delete by Id
                        .Select(cell => cell.RowIndex)
                        .Distinct())
                    {
                        _db.Users.Remove(_users[index]);
                    }

                    _db.SaveChanges(); //this must have, otherwise operations is not saved to base
                    LoadTable(); //simple update datagrid
                }
            }
        }
    }
}
