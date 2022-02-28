using Microsoft.EntityFrameworkCore;

namespace NbgWebApp.Model
{
    public class NbgDbContext: DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("Data Source=localhost;" +
                 "Initial Catalog=NbgCustomer;Integrated Security=True");
        }
        public NbgDbContext(DbContextOptions<NbgDbContext> options)
           : base(options)
        {
        }
    }
}
