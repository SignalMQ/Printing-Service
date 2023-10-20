using BL.Base;
using Printing_Service.Forms;

namespace Printing_Service.Factory
{
    public interface ILoginFactory
    {
        Login Create();
    }

    public class LoginFactory: ILoginFactory
    {
        IAdminFactory _adminFactory;
        ICustomerFactory _customerFactory;
        DBase _db;

        public LoginFactory(IAdminFactory adminFactory, ICustomerFactory customerFactory, DBase db)
        {
            _adminFactory = adminFactory;
            _customerFactory = customerFactory;
            _db = db;
        }

        public Login Create()
        {
            return new Login(_adminFactory, _customerFactory, _db);
        }
    }
}
