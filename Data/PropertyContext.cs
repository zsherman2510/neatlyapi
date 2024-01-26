using Microsoft.EntityFrameworkCore;
using NeatlyApi.Models;

namespace NeatlyApi.Data
{
  public class PropertyDbContext : DbContext
  {
    public PropertyDbContext(DbContextOptions<PropertyDbContext> options) : base(options)
    {
    }

    public DbSet<PropertyEntity> Properties { get; set; }

    // Configure relationships or additional DbSet properties here if needed

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<PropertyEntity>()
          .HasOne(p => p.Customer)
          .WithMany(c => c.Properties) // Assuming you have a Properties navigation property in Customer
          .HasForeignKey(p => p.CustomerId);

      // Configure other relationships and model configurations here if needed
    }
  }
}
