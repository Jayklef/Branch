using Microsoft.EntityFrameworkCore;

namespace Branch.DataAccess
{
    public class BranchContext : DbContext
    {
        public BranchContext(DbContextOptions<BranchContext> options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
