using Internship_4_OOP2.Domain.Entities;
using Internship_4_OOP2.Domain.Persistence.Users;
using Internship_4_OOP2.Infrastructure.Database;
using Internship_4_OOP2.Infrastructure.Interfaces;

namespace Internship_4_OOP2.Infrastructure.Repositories
{
    public sealed class UserRepository : Repository<User, int>, IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IDapperManager _dapperManager;

        public UserRepository(ApplicationDbContext dbContext, IDapperManager dapperManager) : base(dbContext)
        {
            _dbContext = dbContext;
            _dapperManager = dapperManager;
        }
    }
}