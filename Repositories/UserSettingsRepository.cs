using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrivilegesService.Dal;

namespace PrivilegesService.Repositories
{
    public class UserSettingsRepository : IUserSettingsRepository
    {
        private readonly PrivilegesDbContext _dbContext;

        public UserSettingsRepository(PrivilegesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
