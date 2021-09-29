using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrivilegesService.Dal;
using PrivilegesService.Models;

namespace PrivilegesService.Repositories
{
    public class PrivilegesRepository : IPrivilegesRepository
    {
        private readonly PrivilegesDbContext _dbContext;

        public PrivilegesRepository(PrivilegesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<PermissionsEnum>> GetAllPermissions()
        {
            return Enum.GetValues(typeof(PermissionsEnum)).Cast<PermissionsEnum>().ToList();
        }
    }
}
