using Microsoft.EntityFrameworkCore;

namespace project.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<IDoctor> Doctors { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
    }
}
