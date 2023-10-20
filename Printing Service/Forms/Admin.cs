using BL.Base;
using BL.Objects;
using Printing_Service.Factory;

namespace Printing_Service.Forms
{
    public partial class Admin : Form
    {
        private List<User> _users = new List<User>();
        private List<Request> _requests = new List<Request>();
        private readonly ICreateUserFactory _createUserFactory;
        private readonly IEditUserFactory _editUserFactory;
        private readonly DBase _db;
        public Admin(ICreateUserFactory createUserFactory, IEditUserFactory editUserFactory, DBase db)
        {
            InitializeComponent();

            _createUserFactory = createUserFactory;
            _editUserFactory = editUserFactory;
            _db = db;

            Load += Admin_Load;
            KeyDown += Admin_KeyDown;
        }

        private void Admin_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: btnExit_Click(sender, e); break;
            }
        }

        private void Admin_Load(object? sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {
            _users = _db.Users.ToList();
            usersTable.DataSource = _users;
            if (_users.Count > 0)
            {
                LoadRequests(_users[usersTable.CurrentCell.RowIndex]);
            }
        }

        private void LoadRequests(User user)
        {
            _requests.Clear();

            foreach (Request request in _db.Requests.Where(x => x.UserId == user.Id))
            {
                _requests.Add(request);
            }

            requestsTable.DataSource = _requests.Count > 0 ? _requests : null;
        }

        private void createUserItem_Click(object sender, EventArgs e)
        {
            var createUser = _createUserFactory.Create();
            var result = createUser.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                LoadTable();
            }
        }

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

        private void updateTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTable();
            usersTable.Update();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedIndex = usersTable.CurrentCell.RowIndex;
            var user = _users[selectedIndex];
            LoadRequests(user);
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usersTable.Rows.Count > 0)
            {
                if (MessageBox.Show("Do you really want to do this?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var index in usersTable.SelectedCells.Cast<DataGridViewCell>()
                        .Select(cell => cell.RowIndex)
                        .Distinct())
                    {
                        _db.Users.Remove(_users[index]);
                    }

                    _db.SaveChanges();
                    LoadTable();
                }
            }
        }
    }
}
