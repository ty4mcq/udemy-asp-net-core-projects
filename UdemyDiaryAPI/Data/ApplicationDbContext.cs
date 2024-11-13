using Microsoft.EntityFrameworkCore;
using UdemyDiaryAPI.Models;

namespace UdemyDiaryAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<DiaryEntry> DiaryEntries { get; set; }
}