namespace project.Models
{
    public interface IDoctorSpecialization
    {

        int DoctorId { get; set; }
        string SpecializationCode { get; set; }
        DateTime SpecializationDate { get; set; }
    }
}
