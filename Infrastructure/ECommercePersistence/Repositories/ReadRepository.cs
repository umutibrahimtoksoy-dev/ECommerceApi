using ECommerceApplication.Repositories;
using ECommerceDomain.Entities.Common;
using ECommercePersistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommercePersistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceDbContext _eCommerceDbContext;

        public ReadRepository(ECommerceDbContext eCommerceDbContext)
        {
            _eCommerceDbContext = eCommerceDbContext;
        }

        public DbSet<T> Table => _eCommerceDbContext.Set<T>();

        public IQueryable<T> GetAll(bool isTracking)
        {
            if (!isTracking)
            {
                return Table
                    .AsNoTracking();
            }
            return Table;
        }

        public async Task<T> GetById(int id, bool isTracking)
        {
            if (!isTracking)
            {
                return await Table
                    .AsNoTracking()
                    .FirstOrDefaultAsync(f => f.Id == id);
            }
            return await Table.FindAsync(id);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool isTracking)
        {
            if (!isTracking)
            {
                return await Table
                    .AsNoTracking()
                    .SingleOrDefaultAsync(method);
            }
            return await Table.SingleOrDefaultAsync(method);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> method, bool isTracking)
        {
            if (!isTracking)
            {
                return Table
                    .AsNoTracking()
                    .Where(method);
            }
            return Table.Where(method);
        }
    }
}
