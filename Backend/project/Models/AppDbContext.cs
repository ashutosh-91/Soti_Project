using Microsoft.EntityFrameworkCore;

namespace project.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorSpecialization>().HasKey(e => new { e.DoctorId,e.SpecializationCode});
            modelBuilder.Entity<DoctorSpecialization>().HasOne<IDoctor>().WithMany().HasForeignKey(d => d.DoctorId);
            modelBuilder.Entity<DoctorSpecialization>().HasOne<Specialization>().WithMany().HasForeignKey(d => d.SpecializationCode);
        }
        public DbSet<IDoctor> Doctors { get; set; }
        public DbSet<Specialization> Specializations { get; set; }

        public DbSet<ISurgery> Surgery { get; set; }
        public DbSet<DoctorSpecialization> DoctorSpecialization { get; set; }
    }
}
