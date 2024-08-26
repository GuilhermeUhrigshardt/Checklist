using System;

namespace ChecklistGestran.Application.Contracts.Persistence;

public interface IBaseRepository<T> where T : class
{
    Task<T> GetAsync();
    Task<T> GetByIdAsync(Guid id);
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
}