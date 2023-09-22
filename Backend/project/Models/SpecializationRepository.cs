using System.Numerics;

namespace project.Models
{
    public interface SpecializationRepository
    {
        List<Specialization> GetAllSpecializations();
        Specialization GetSpecializationByCode(string code);
        bool AddSpecialization(Specialization specialization);
        bool UpdateSpecialization(Specialization specialization);
        bool DeleteSpecialization(string code);
    }
}
