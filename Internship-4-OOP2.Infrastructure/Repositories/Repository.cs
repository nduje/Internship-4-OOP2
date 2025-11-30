using Internship_4_OOP2.Domain.Common.Model;
using Internship_4_OOP2.Domain.Entities;
using Internship_4_OOP2.Domain.Persistence.Common;
using Microsoft.EntityFrameworkCore;

namespace Internship_4_OOP2.Infrastructure.Repositories
{
    public class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<User> _dbSetUser;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSetUser = _context.Set<User>();
        }

        public async Task<GetAllUsersRequest> GetUsers()
        {
            var users = await _dbSetUser.ToListAsync();
            return new GetAllUsersRequest { Users = users };
        }
    }
}
