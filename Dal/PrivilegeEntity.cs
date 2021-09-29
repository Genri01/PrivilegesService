using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using PrivilegesService.Models;

namespace PrivilegesService.Dal
{
    [Table("Privileges")]
    public class PrivilegeEntity
    {
        [Key]
        public Guid PrivilegeId { get; set; }
        public PermissionsEnum[] Permissions { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset LastSavedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
