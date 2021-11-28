using Microsoft.EntityFrameworkCore;
using UpscGeek.Core.Entities;

namespace UpscGeek.Infrastructure.Data
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options):base(options)
        {
        }
        public DbSet<Subject> Subjects { get; set; }
    }
}