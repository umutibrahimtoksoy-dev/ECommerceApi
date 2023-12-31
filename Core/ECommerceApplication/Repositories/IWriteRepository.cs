﻿using ECommerceDomain.Entities.Common;

namespace ECommerceApplication.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<int> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entity);
        int Update(T entity);
        bool Remove(T entity);
        bool RemoveRange(List<T> entity);
        Task<bool> RemoveAsync(int id);
        Task<int> SaveChangesAsync();
    }
}
