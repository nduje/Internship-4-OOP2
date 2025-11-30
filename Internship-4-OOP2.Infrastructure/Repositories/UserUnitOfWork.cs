using Internship_4_OOP2.Domain.Persistence.Users;
using Internship_4_OOP2.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_4_OOP2.Infrastructure.Repositories
{
    internal class UserUnitOfWork : IUserUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public IUserRepository Repository { get; set; }

        public UserUnitOfWork(ApplicationDbContext dbContext, IUserRepository repository)
        {
            _dbContext = dbContext;
            Repository = repository;
        }

        public async Task CreateTransaction()
        {
            await _dbContext.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
            await _dbContext.Database.CommitTransactionAsync();
        }

        public async Task Rollback()
        {
            await _dbContext.Database.RollbackTransactionAsync();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
