namespace project.Models
{
    public interface DoctorSpecializationRepository
    {
        public List<DoctorSpecialization> GetDoctorsBySpecializations(string specializationCode);
    }
}
