namespace project.Models
{
    public interface DoctorRepository
    {
        List<IDoctor> GetAllDoctors();
        bool AddDoctor(IDoctor doctor);
        bool UpdateDoctorDetails(IDoctor doctor);
        bool DeleteDoctor(int id);
    }
}
