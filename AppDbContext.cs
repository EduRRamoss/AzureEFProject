using Microsoft.EntityFrameworkCore;

namespace AzureProject;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<StudyAzure> StudyAzure { get; set; }
}

public class StudyAzure
{
    public int Id { get; set; }
    public string Azure { get; set; }
    public string Study { get; set; }
}
