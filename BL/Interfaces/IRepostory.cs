namespace BL.Interfaces
{
    public interface IRepostory<T> where T : class
    {
        public bool Create(T entity);
        public bool Update(T entity);
        public bool Delete(int deleteid);
        public IEnumerable<T> Getall();
        public T GetById(int id);
    }
}
