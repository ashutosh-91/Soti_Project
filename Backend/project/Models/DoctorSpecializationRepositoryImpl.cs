using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            return _context.DoctorSpecialization.Where(e => e.SpecializationCode == specializationCode).ToList();
        }

        public bool AddDoctorSpecialization(DoctorSpecialization doctorSpecialization)
        {
            try
            {
                _context.DoctorSpecialization.Add(doctorSpecialization);
                int rows = _context.SaveChanges();
                if (rows > 0)
                {
                    return true;
                }
                return false;

            } catch (Exception ex)
            {
                return false;
            }
           
        }

    }
}
