using JoinClass.Domain.Models.Shared;

namespace JoinClass.Domain.Contracts.Repositories.Write
{
    public interface IRepository<T> where T : BaseModel
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}