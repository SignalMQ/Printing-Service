using BL.Base;
using BL.Objects;
using Printing_Service.Forms;

namespace Printing_Service.Factory
{
    // see AdminFactory.cs for comments
    public interface IEditUserFactory
    {
        EditUser Create(User user);
    }

    public class EditUserFactory: IEditUserFactory
    {
        DBase _db;
        public EditUserFactory(DBase db, User user)
        {
            _db = db;
        }
        public EditUser Create(User user)
        {
            return new EditUser(_db, user);
        }
    }
}
