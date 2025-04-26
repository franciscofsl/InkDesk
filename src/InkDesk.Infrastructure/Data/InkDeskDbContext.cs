using InkDesk.Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Raftel.Infrastructure.Data;

namespace InkDesk.Infrastructure.Data;

public class InkDeskDbContext : RaftelDbContext<InkDeskDbContext>
{
    public InkDeskDbContext() : base()
    {
    }

    public InkDeskDbContext(DbContextOptions<InkDeskDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(InkDeskDbContext).Assembly);
    }
}