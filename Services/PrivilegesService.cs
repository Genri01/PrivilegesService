using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using PrivilegesService.Dal;
using PrivilegesService.Models;
using PrivilegesService.Repositories;

namespace PrivilegesService.Services
{
    public class PrivilegesService : IPrivilegesService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserSettingsRepository _userSettingsRepository;
        private readonly IPrivilegesRepository _privilegesRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<IPrivilegesService> _logger;

        public PrivilegesService(IUserRepository _userRepository, IUserSettingsRepository _userSettingsRepository, IPrivilegesRepository _privilegesRepository, IMapper _mapper, ILogger<IPrivilegesService> _logger)
        {
            this._userRepository = _userRepository;
            this._userSettingsRepository = _userSettingsRepository;
            this._privilegesRepository = _privilegesRepository;
            this._mapper = _mapper;
            this._logger = _logger;
        }

        public async Task<IEnumerable<PermissionsEnum>> GetPermissionsPrivileges()
        {
            return await _privilegesRepository.GetAllPermissions();
        }

        public async Task<UserModelDto> CreateUser(UserModelDto user)
        {
            var entity = _mapper.Map<UserEntity>(user);
            var userEntity = await _userRepository.CreateUser(entity);

            return _mapper.Map<UserModelDto>(userEntity);
        }
    }
}
