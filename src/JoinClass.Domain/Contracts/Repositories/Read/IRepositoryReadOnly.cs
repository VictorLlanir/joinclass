using JoinClass.Domain.Models.Shared;

namespace JoinClass.Domain.Contracts.Repositories.Read
{
    public interface IRepositoryReadOnly<T> where T : BaseModel
    {
        Task<T> GetByIdAsync(int id);
        Task<IQueryable<T>> GetAllAsync();
    }
}