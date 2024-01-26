using Microsoft.EntityFrameworkCore;
using NeatlyApi.Models;

namespace NeatlyApi.Data
{
  public class CustomerDbContext : DbContext
  {
    public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
    {
    }

    public DbSet<CustomerEntity> Customers { get; set; }

    // Configure relationships or additional DbSet properties here if needed

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<CustomerEntity>()
         .HasMany(c => c.Jobs)
         .WithOne(j => j.Customer)
         .HasForeignKey(j => j.CustomerId);

      modelBuilder.Entity<CustomerEntity>()
          .HasMany(c => c.Properties)
          .WithOne(p => p.Customer)
          .HasForeignKey(p => p.CustomerId);
    }
  }
}


