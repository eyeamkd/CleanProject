using Microsoft.EntityFrameworkCore;
using Project.Domain;

namespace Project.Infrastructure
{
    public class ProjectDBContext : DbContext
    {
        public string DbPath { get; }
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "Project.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Entity> Entities { get; set; }
    }
}
