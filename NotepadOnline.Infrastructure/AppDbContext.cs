using Microsoft.EntityFrameworkCore;

namespace NotepadOnline.Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<Models.Note> Notes { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Models.Note>(entity =>
        {
            entity.HasKey(e => e.Id);
        });
        base.OnModelCreating(modelBuilder);
    }
}