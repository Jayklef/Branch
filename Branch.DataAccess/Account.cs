using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Branch.DataAccess
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength (128)]
        public string CompanyName { get; set; }
        public string Website { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
