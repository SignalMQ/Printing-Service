using BL.Base;
using Printing_Service.Forms;

namespace Printing_Service.Factory
{
    /// <summary>
    /// Main interface of Admin Form for creating object
    /// </summary>
    public interface IAdminFactory
    {
        Admin Create(); //this method used in ServiceProvider
    }

    /// <summary>
    /// Admin form creator realization of interface
    /// </summary>
    public class AdminFactory: IAdminFactory 
    {
        ICreateUserFactory _createUserFactory; //some factoryes for creating other forms in Admin.cs
        IEditUserFactory _editUserFactory;
        DBase _db;

        public AdminFactory(ICreateUserFactory createUserFactory, IEditUserFactory editUserFactory, DBase db) //user for creating objects before using Form
        {
            _createUserFactory = createUserFactory; //interface = realization of object
            _editUserFactory = editUserFactory;
            _db = db;
        }

        public Admin Create()
        {
            return new Admin(_createUserFactory, _editUserFactory, _db); //creates the needed form and give objects with parameters to target form realization and return this form
        }
    }
}
