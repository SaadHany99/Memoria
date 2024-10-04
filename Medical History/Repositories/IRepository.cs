namespace Medical_History.Repositories
{
    public interface IRepository<T> where T : class
    { 
        public Task<List<T>> GetAll();
        public Task<T> GetById(int id);
        public Task Add(T entity);
        public Task Update(T entity);
        public Task DeleteById(int id);

    }
}
