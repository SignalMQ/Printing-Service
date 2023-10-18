using BL.Interfaces;
using BL.Objects;

namespace BL.Repository
{
    public class Repository : IRepostory<User>
    {
        private readonly MyDbContext.MyDbContext _myDbContext;

        public Repository(MyDbContext.MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public bool Create(User user)
        {
            if (user != null)
            {
                _myDbContext.Users.Add(user);
                _myDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int deleteid)
        {
            var deletedobject = _myDbContext.Users.FirstOrDefault(x => x.Id == deleteid);
            if (deletedobject != null)
            {
                _myDbContext.Users.Remove(deletedobject);
                _myDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<User> Getall()
        {
            var getalluser = _myDbContext.Users;
            if (getalluser != null)
            {
                return getalluser;
            }
            return Enumerable.Empty<User>();
        }

        public User GetById(int id)
        {
            var getbyiduser = _myDbContext.Users.FirstOrDefault(x => x.Id == id);
            if (getbyiduser != null)
            {
                return getbyiduser;
            }
            return null;
        }

        public bool Update(User entity)
        {
            var Updatedobject = _myDbContext.Users.FirstOrDefault(x => x.Id == entity.Id);
            if (Updatedobject != null)
            {
                Updatedobject.Username = entity.Username;
                Updatedobject.Username = entity.Username;
                Updatedobject.Password = entity.Password;
                Updatedobject.Role = entity.Role;
                _myDbContext.Users.Update(Updatedobject);
                _myDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
