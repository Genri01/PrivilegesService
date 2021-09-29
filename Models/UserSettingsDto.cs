using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace PrivilegesService.Models
{
    public class UserSettingsDto
    {
        public Guid UserSettingsId { get; set; }
        
        [Required]
        [RegularExpression("[A-Za-z ]*", ErrorMessage = "Invalid FirstName ")]
        public string FirstName { get; set; }

        [RegularExpression("[A-Za-z ]*", ErrorMessage = "Invalid LastName ")]
        public string LastName { get; set; }
        
        [Range(1, 150, ErrorMessage = "Value must be between 1 and 150")]
        public int Age { get; set; }
    }
}
