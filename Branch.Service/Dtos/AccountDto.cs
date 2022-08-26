using Branch.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Branch.Service.Dtos
{
    public class AccountDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
