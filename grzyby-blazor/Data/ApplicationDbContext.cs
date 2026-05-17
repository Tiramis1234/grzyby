using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using grzyby.Models;

namespace grzyby.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Grzyb> Grzyby { get; set; }
    public DbSet<Wpis> Wpisy { get; set; }
    public DbSet<Komentarz> Komentarze { get; set; }
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Grzyb>().HasData(SeedData.Grzyby);
    }
}