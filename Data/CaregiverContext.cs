using Microsoft.EntityFrameworkCore;
using NeatlyApi.Models;

namespace NeatlyApi.Data
{
  public class CaregiverDbContext : DbContext
  {
    public CaregiverDbContext(DbContextOptions<CaregiverDbContext> options) : base(options)
    {
    }

    public DbSet<CaregiverEntity> Caregivers { get; set; }

    // Configure relationships or additional DbSet properties here if needed

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      // Configure entity relationships and other model configurations here
    }
  }
}
