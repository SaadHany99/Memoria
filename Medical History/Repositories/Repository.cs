
using Medical_History.Data;
using Microsoft.EntityFrameworkCore;

namespace Medical_History.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;

        public Repository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {
            var Entity = await dbContext.Set<T>().FindAsync(id);
            if(Entity == null)
            {
                dbContext.Set<T>().Remove(Entity);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<T>> GetAll()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public async Task Update(T entity)
        {
             dbContext.Set<T>().Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
