using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrivilegesService.Models;

namespace PrivilegesService.Services
{
    public interface IPrivilegesService
    {
        Task<IEnumerable<PermissionsEnum>> GetPermissionsPrivileges();
        Task<UserModelDto> CreateUser(UserModelDto user);
    }
}
