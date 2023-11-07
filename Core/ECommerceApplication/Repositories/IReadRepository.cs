using ECommerceDomain.Models.Common;
using System.Linq.Expressions;

namespace ECommerceApplication.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> method);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetById(int id);
    }
}
