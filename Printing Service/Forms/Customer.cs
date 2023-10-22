using BL.Base;
using BL.Objects;

namespace Printing_Service.Forms
{
    public partial class Customer : Form
    {
        private DBase _db;
        private User _user;
        private List<Request> _requests = new();

        private double Price { get; set; }

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
            _user.Requests.Add(new Request
            {
                UserId = _user.Id,
                Service = serviceCombo.Text,
                Price = Price,
                IsSurcharged = urgentCheckbox.Checked,
                Status = "Pending"
            });

            _db.Users.Update(_user);
            _db.SaveChanges();

            LoadRequests(_user);
        }

        private void ValueChanged(object sender, EventArgs e)
        {

            switch (serviceCombo.SelectedIndex)
            {
                case 0: Price = Prices.PrintingA4BlackAndWhite * ((long)quantityUpDown.Value); break;
                case 1: Price = Prices.PrintingA4Color * ((long)quantityUpDown.Value); break;
                case 2: Price = Prices.BindingCombBinding * ((long)quantityUpDown.Value); break;
                case 3: Price = Prices.BindingThickCover * ((long)quantityUpDown.Value); break;
                case 4: Price = Prices.PosterPrinting * ((long)quantityUpDown.Value); break;
                case 5: Price = Prices.PosterPrinting * ((long)quantityUpDown.Value); break;
                case 6: Price = Prices.PosterPrinting * ((long)quantityUpDown.Value); break;
                case 7: Price = Prices.Banner * ((long)quantityUpDown.Value); break;
            }

            Price = urgentCheckbox.Checked ? Price + Price * 0.3 : Price;

            txtTotal.Text = Math.Abs(Price).ToString();
        }
    }
}
