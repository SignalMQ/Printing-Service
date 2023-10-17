using BL.Base;
using Printing_Service.Forms;

namespace Printing_Service.Factory
{
    public interface IAdminFactory
    {
        Admin Create();
    }

    public class AdminFactory: IAdminFactory
    {
        ICreateUserFactory _createUserFactory;
        IEditUserFactory _editUserFactory;
        DBase _db;

        public AdminFactory(ICreateUserFactory createUserFactory, IEditUserFactory editUserFactory, DBase db)
        {
            _createUserFactory = createUserFactory;
            _editUserFactory = editUserFactory;
            _db = db;
        }

        public Admin Create()
        {
            return new Admin(_createUserFactory, _editUserFactory, _db);
        }
    }
}
