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
        DBase _db;

        public LoginFactory(IAdminFactory adminFactory, DBase db)
        {
            _adminFactory = adminFactory;
            _db = db;
        }

        public Login Create()
        {
            return new Login(_adminFactory, _db);
        }
    }
}
