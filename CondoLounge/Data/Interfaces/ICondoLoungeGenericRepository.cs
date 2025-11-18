namespace CondoLounge.Data.Interfaces
{
    public interface ICondoLoungeGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveAll();
    }
}
