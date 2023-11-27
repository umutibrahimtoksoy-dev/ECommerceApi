using ECommerceDomain.Entities.Common;
using System.Linq.Expressions;

namespace ECommerceApplication.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool isTracking = false);
        Task<List<T>> GetListAsync(bool isTracking = false);
        IQueryable<T> Where(Expression<Func<T, bool>> method, bool isTracking = false);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool isTracking = false);
        Task<T> GetByIdAsync(int id, bool isTracking = false);
    }
}
