using Internship_4_OOP2.Domain.Common.Model;

namespace Internship_4_OOP2.Domain.Persistence.Common
{
    public interface IRepository<TEntity, TId> where TEntity : class
    {
        Task<GetAllUsersRequest> GetUsers();
    }
}
