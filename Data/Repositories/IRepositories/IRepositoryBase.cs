namespace  Data.Repositories.Interfaces
{
    public interface IRepositoryBase<T>
    {
         void  Add(T entity); 
        void Update(T entity);
        void Delete(T entity);
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();

    }
}
