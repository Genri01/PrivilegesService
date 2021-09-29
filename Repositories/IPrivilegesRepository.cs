using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrivilegesService.Models;

namespace PrivilegesService.Repositories
{
    public interface IPrivilegesRepository
    {
        Task<IEnumerable<PermissionsEnum>> GetAllPermissions();
    }
}
