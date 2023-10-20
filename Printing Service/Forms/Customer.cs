using BL.Base;
using BL.Objects;

namespace Printing_Service.Forms
{
    public partial class Customer : Form
    {
        private DBase _db;
        private User _user;
        private List<Request> _requests = new();

        public Customer(DBase db, User user)
        {
            InitializeComponent();

            _db = db;
            _user = user;

            LoadRequests(_user);
        }

        private void LoadRequests(User user)
        {
            _requests.Clear();

            foreach (Request request in _db.Requests.Where(x => x.UserId == user.Id))
            {
                _requests.Add(request);
            }

            requestsTable.DataSource = _requests;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {

        }
    }
}
