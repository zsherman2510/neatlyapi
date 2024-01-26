using Microsoft.EntityFrameworkCore;
using NeatlyApi.Models;

namespace NeatlyApi.Data
{
  public class JobDbContext : DbContext
  {
    public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
    {
    }

    public DbSet<JobEntity> Jobs { get; set; }

    // Configure relationships or additional DbSet properties here if needed

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<JobEntity>()
           .HasOne(j => j.Customer)
           .WithMany(c => c.Jobs)
           .HasForeignKey(j => j.CustomerId);

      modelBuilder.Entity<JobEntity>()
          .HasOne(j => j.Property)
          .WithMany(p => p.Jobs)
          .HasForeignKey(j => j.PropertyId);

      modelBuilder.Entity<JobEntity>()
          .HasOne(j => j.Caregiver)
          .WithMany(c => c.Jobs)
          .HasForeignKey(j => j.CaregiverId);
    }
  }
}
