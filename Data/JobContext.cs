using Microsoft.EntityFrameworkCore;

namespace JobContext.Data
{
  public class JobDbContext : DbContext
  {
    public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
    {
    }

    public DbSet<Job> Jobs { get; set; }

    // Configure relationships or additional DbSet properties here if needed

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Job>()
           .HasOne(j => j.Customer)
           .WithMany(c => c.Jobs)
           .HasForeignKey(j => j.CustomerId);

      modelBuilder.Entity<Job>()
          .HasOne(j => j.Property)
          .WithMany(p => p.Jobs)
          .HasForeignKey(j => j.PropertyId);

      modelBuilder.Entity<Job>()
          .HasOne(j => j.Cleaner)
          .WithMany(c => c.Jobs)
          .HasForeignKey(j => j.CleanerId);
    }
  }
}
