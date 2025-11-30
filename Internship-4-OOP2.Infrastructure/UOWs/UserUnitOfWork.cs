using Internship_4_OOP2.Domain.Persistence.Users;
using Internship_4_OOP2.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_4_OOP2.Infrastructure.UOWs
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
    }
}
