using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using PrivilegesService.Models;

namespace PrivilegesService.Dal
{
    [Table("UserSettings")]
    public class UserSettingsEntity
    {
        [Key]
        public Guid UserSettingsId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset LastSavedDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
