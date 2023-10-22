using BL.Base;
using BL.Objects;

namespace Printing_Service.Forms
{
    public partial class Customer : Form
    {
        private DBase _db;
        private User _user;
        private List<Request> _requests = new(); //new() is alternative for new List<Request>()

        private double Price { get; set; } //variable for price showing in textbox

        public Customer(DBase db, User user)
        {
            InitializeComponent();

            _db = db;
            _user = user;

            LoadRequests(_user);
        }

        /// <summary>
        /// Load requests from logined customer
        /// </summary>
        /// <param name="user"></param>
        private void LoadRequests(User user)
        {
            _requests.Clear();

            foreach (Request request in _db.Requests.Where(x => x.UserId == user.Id).ToList())
            {
                _requests.Add(request);
            }

            requestsTable.DataSource = _requests;
            requestsTable.Update();
        }

        /// <summary>
        /// Create request and save to base, after manager is link request to worker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Event for calculating price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            Price = urgentCheckbox.Checked ? Price + Price * 0.3 : Price; //surcharge 30% if checkbox is checked

            txtTotal.Text = Math.Abs(Price).ToString(); //textbox view total price
        }
    }
}
