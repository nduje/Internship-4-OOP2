using Internship_4_OOP2.Domain.Entities.Users;
using Internship_4_OOP2.Domain.Persistence.Users;
using Internship_4_OOP2.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

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

        public async Task<User> GetById(int id)
        {
            var sql =
            """
                SELECT
                    id AS Id,
                    name AS Name
                FROM
                    public.users
                WHERE
                    id = @Id
            """;

            var parameters = new
            {
                Id = id
            };

            return await _dapperManager.QuerySingleAsync<User>(sql, parameters);
        }
    }
}
