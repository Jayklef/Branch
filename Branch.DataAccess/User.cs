using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Branch.DataAccess
{
    public class User
    {
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [MaxLength(128)]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Unique]
        [EmailAddress]
        public string Email { get; set; }
    }
}
