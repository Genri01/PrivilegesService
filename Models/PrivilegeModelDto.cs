using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegesService.Models
{
    public class PrivilegeModelDto
    {
        private Guid PriviligeId { get; set; }
        public IEnumerable<PermissionsEnum> Permissions { get; set; }
    }
}
