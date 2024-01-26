using Microsoft.EntityFrameworkCore;

namespace CustomerContext.Data
{
  public class CustomerDbContext : DbContext
  {
    public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }

    // Configure relationships or additional DbSet properties here if needed

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Customer>()
         .HasMany(c => c.Jobs)
         .WithOne(j => j.Customer)
         .HasForeignKey(j => j.CustomerId);

      modelBuilder.Entity<Customer>()
          .HasMany(c => c.Properties)
          .WithOne(p => p.Customer)
          .HasForeignKey(p => p.CustomerId);
    }
  }
}
