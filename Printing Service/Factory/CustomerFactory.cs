using BL.Base;
using BL.Objects;
using Printing_Service.Forms;

namespace Printing_Service.Factory
{
    public interface ICustomerFactory
    {
        Customer Create(User user);
    }

    public class CustomerFactory: ICustomerFactory
    {
        DBase _db;

        public CustomerFactory(DBase db)
        {
            _db = db;
        }
        
        public Customer Create(User user)
        {
            return new Customer(_db, user);
        }
    }
}
