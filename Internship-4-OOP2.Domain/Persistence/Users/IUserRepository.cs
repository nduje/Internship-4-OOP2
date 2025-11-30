using Internship_4_OOP2.Domain.Common.Model;
using Internship_4_OOP2.Domain.Entities;
using Internship_4_OOP2.Domain.Persistence.Common;

namespace Internship_4_OOP2.Domain.Persistence.Users
{
    public interface IUserRepository : IRepository<User, int>
    {
        Task<User> GetById(int id);
    }
}
