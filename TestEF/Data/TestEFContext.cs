using Microsoft.EntityFrameworkCore;
using TestEF.Model;

namespace TestEF.Data
{
    public class TestEFContext : DbContext
    {
        public TestEFContext()
        {
        }

        public TestEFContext(DbContextOptions<TestEFContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }

      



    }
}