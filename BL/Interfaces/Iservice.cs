namespace BL.Interfaces
{
    public interface Iservice<T> where T : class
    {
        public string Create(T entity);
        public string Update(T entity);
        public string Delete(int deletedid);
        public IEnumerable<T> Getall();
        public T GetById(int id);
    }
}
