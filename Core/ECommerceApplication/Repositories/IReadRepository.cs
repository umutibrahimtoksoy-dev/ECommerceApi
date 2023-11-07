using ECommerceDomain.Models.Common;
using System.Linq.Expressions;

namespace ECommerceApplication.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool isTracking);
        IQueryable<T> Where(Expression<Func<T, bool>> method, bool isTracking);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool isTracking);
        Task<T> GetById(int id, bool isTracking);
    }
}
