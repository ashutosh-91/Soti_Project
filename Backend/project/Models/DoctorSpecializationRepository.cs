namespace project.Models
{
    public interface DoctorSpecializationRepository
    {
        public List<DoctorSpecialization> GetDoctorsBySpecializations(string specializationCode);
        bool AddDoctorSpecialization(DoctorSpecialization doctorSpecialization);
    }
}
