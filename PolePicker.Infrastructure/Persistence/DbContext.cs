using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PolePicker.Domain.Entities;
using PolePicker.Infrastructure.Options;

namespace PolePicker.Infrastructure.Persistence;

public class AppDbContext(IOptions<ConnectionStringsOptions> config) : DbContext
{
    public DbSet<Group> Groups => Set<Group>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        optionsBuilder.UseNpgsql(config.Value.AppDbContext);

        base.OnConfiguring(optionsBuilder);
    }
}