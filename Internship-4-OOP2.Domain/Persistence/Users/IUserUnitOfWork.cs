using Internship_4_OOP2.Domain.Persistence.Common;

namespace Internship_4_OOP2.Domain.Persistence.Users
{
    public interface IUserUnitOfWork : IUnitOfWork
    {
        IUserRepository Repository { get; }
    }
}
