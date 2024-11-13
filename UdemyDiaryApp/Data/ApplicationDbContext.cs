using Microsoft.EntityFrameworkCore;
using UdemyDiaryApp.Models;

namespace UdemyDiaryApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<DiaryEntry> DiaryEntries { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<DiaryEntry>().HasData(
            new DiaryEntry {
                Id = 1,
                Title = "First Entry",
                Content = "This is the first entry in the diary.",
                Created = DateTime.Now
            },
            new DiaryEntry {
                Id = 2,
                Title = "Second Entry",
                Content = "This is the second entry in the diary.",
                Created = DateTime.Now
            }
            );
    }
}