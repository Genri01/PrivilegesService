using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegesService.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PermissionsEnum
    {
        ViewAllUsers,
        CreateUsers,
        BlockUser,
        EditUserSettings,
        UnlockUser
    }
}
