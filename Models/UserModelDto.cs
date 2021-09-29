using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegesService.Models
{
    public class UserModelDto
    {
        public Guid UserId { get; set; }
        public UserSettingsDto UserSettings { get; set; }
        public PrivilegeModelDto Privilege { get; set; }
    }
}
