using Microsoft.EntityFrameworkCore;

namespace UdemyDiaryApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}