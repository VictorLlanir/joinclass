using JoinClass.Domain.Contracts.Repositories.Write;
using JoinClass.Domain.Models.Shared;

namespace JoinClass.Infrastructure.Repositories.Write
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}