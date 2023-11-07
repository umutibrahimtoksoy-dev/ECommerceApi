using ECommerceApplication.Repositories;
using ECommerceDomain.Models.Common;
using ECommercePersistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommercePersistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ECommerceDbContext _eCommerceDbContext;

        public WriteRepository(ECommerceDbContext eCommerceDbContext)
        {
            _eCommerceDbContext = eCommerceDbContext;
        }

        public DbSet<T> Table => _eCommerceDbContext.Set<T>();

        public async Task<int> AddAsync(T entity)
        {
            await Table.AddAsync(entity);

            return entity.Id;
        }

        public async Task<bool> AddRangeAsync(List<T> entityList)
        {
            await Table.AddRangeAsync(entityList);
            return true;
        }

        public int Update(T entity)
        {
            Table.Update(entity);

            return entity.Id;
        }

        public bool Remove(T entity)
        {
            Table.Remove(entity);

            return true;
        }

        public bool RemoveRange(List<T> entityList)
        {
            Table.RemoveRange(entityList);

            return true;
        }

        public async Task<bool> Remove(int id)
        {
            var entity = await Table.FindAsync(id);

            Table.Remove(entity);

            return true;
        }

        public Task<int> SaveChangesAsync() => _eCommerceDbContext.SaveChangesAsync();
    }
}
