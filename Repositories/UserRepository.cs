using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrivilegesService.Dal;
using PrivilegesService.Models;

namespace PrivilegesService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PrivilegesDbContext _dbContext;

        public UserRepository(PrivilegesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserEntity> CreateUser(UserEntity user)
        {
            var entity = await _dbContext.Users.AddAsync(user);
            return entity.Entity;
        }
    }
}
