using JoinClass.Domain.Contracts.Repositories.Read;
using JoinClass.Domain.Models.Shared;

namespace JoinClass.Infrastructure.Repositories.Read
{
    public class RepositoryReadOnly<T> : IRepositoryReadOnly<T> where T : BaseModel
    {
        public Task<IQueryable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}