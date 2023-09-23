using System.Numerics;

namespace project.Models
{
    public interface SpecializationRepository
    {
        List<Specialization> GetAllSpecializations();
        Specialization GetSpecializationByCode(string code);
        bool AddSpecialization(Specialization specialization);
        bool UpdateSpecialization(Specialization specialization);
     
        Specialization GetSpecializationByName(string name);
        bool DeleteSpecialization(string code);
    }
}
