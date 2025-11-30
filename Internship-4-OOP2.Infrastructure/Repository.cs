using Internship_4_OOP2.Domain.Common.Model;
using Internship_4_OOP2.Domain.Entities.Users;
using Internship_4_OOP2.Domain.Persistence.Common;
using Microsoft.EntityFrameworkCore;

namespace Internship_4_OOP2.Infrastructure
{
    public class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        private readonly DbSet<User> _dbSetUser;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
            _dbSetUser = _context.Set<User>();
        }

        public async Task<GetAllRequest<TEntity>> Get()
        {
            var entities = await _dbSet.ToListAsync();
            return new GetAllRequest<TEntity> { Values = entities };
        }

        public async Task<GetAllUsersRequest> GetUsers()
        {
            var users = await _dbSetUser.ToListAsync();
            return new GetAllUsersRequest { Users = users };
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public async Task DeleteAsync(TId id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public void Delete(TEntity? entity)
        {
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }
    }
}
