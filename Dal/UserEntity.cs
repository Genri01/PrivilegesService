using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using PrivilegesService.Models;

namespace PrivilegesService.Dal
{
    [Table("Users")]
    public class UserEntity
    {
        [Key]
        public Guid UserId { get; set; }
        [ForeignKey("UserSettingsEntity")]
        public Guid UserSettingsId { get; set; }
        public UserSettingsEntity UserSettings { get; set; }

        [ForeignKey("PrivilegeEntity")]
        public Guid PrivilegeId { get; set; }
        public PrivilegeEntity Privilege { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset LastSavedDate { get; set; }
    }
}
