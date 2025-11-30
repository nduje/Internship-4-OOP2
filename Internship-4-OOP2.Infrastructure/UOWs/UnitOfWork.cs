using Internship_4_OOP2.Domain.Persistence.Common;
using Internship_4_OOP2.Infrastructure.Database;

namespace Internship_4_OOP2.Infrastructure.UOWs
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
