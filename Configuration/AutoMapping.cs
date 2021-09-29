using AutoMapper;
using PrivilegesService.Dal;
using PrivilegesService.Models;

namespace PrivilegesService.Configuration
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<UserEntity, UserModelDto>();
            CreateMap<UserSettingsEntity, UserSettingsDto>();
            CreateMap<PrivilegeEntity, PrivilegeModelDto>();
        }
    }
}
