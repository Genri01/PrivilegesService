using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrivilegesService.Dal;

namespace PrivilegesService.Repositories
{
    public interface IUserRepository
    {
        Task<UserEntity> CreateUser(UserEntity user);
    }
}
