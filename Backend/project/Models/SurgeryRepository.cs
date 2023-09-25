namespace project.Models
{
    public interface SurgeryRepository
    {
        List<ISurgery> GetAllSurgeryTypeForToday();
        bool UpdateSurgery(ISurgery surgery);

        bool AddSurgery(ISurgery surgery); 

    }
}
