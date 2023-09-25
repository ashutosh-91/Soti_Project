namespace project.Models
{
    public class DoctorSpecializationRepositoryImpl : DoctorSpecializationRepository
    {
        private readonly AppDbContext _context;
        public DoctorSpecializationRepositoryImpl(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public List<DoctorSpecialization> GetDoctorsBySpecializations(string specializationCode)
        {
          return  _context.DoctorSpecialization.Where(e=>e.SpecializationCode==specializationCode).ToList();
        }
    }
}
