using BL.Base;
using Printing_Service.Forms;

namespace Printing_Service.Factory
{
    // see AdminFactory.cs for comments
    public interface ICreateUserFactory
    {
        CreateUser Create();
    }

    public class CreateUserFactory: ICreateUserFactory
    {
        DBase _db;
        public CreateUserFactory(DBase db)
        {
            _db = db;
        }
        public CreateUser Create()
        {
            return new CreateUser(_db);
        }
    }
}
