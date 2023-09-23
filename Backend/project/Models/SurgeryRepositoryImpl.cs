namespace project.Models
{
    public class SurgeryRepositoryImpl : SurgeryRepository
    {
        private readonly AppDbContext _context;
        public SurgeryRepositoryImpl(AppDbContext _con) { 
              _context = _con;
        }
        public bool AddSurgery(ISurgery surgery)
        {
            _context.Add(surgery);
            int rows=_context.SaveChanges();

            return (rows>0)?true:false;
        }

        public List<ISurgery> GetAllSurgeryTypeForToday()
        {
            var surgery_data=_context.Surgery.ToList();
            return surgery_data;
        }

        public bool UpdateSurgery(ISurgery surgery)
        {

            var surgery_data = _context.Surgery.FirstOrDefault(x => x.SurgeryId == surgery.SurgeryId);
            if (surgery_data != null)
            {
                surgery_data.SurgeryDate = surgery.SurgeryDate;
                surgery_data.SurgeryCategory=surgery.SurgeryCategory;
                surgery_data.DoctorId = surgery.DoctorId;
                surgery_data.StartTime= surgery.StartTime;
                surgery_data.EndTime= surgery.EndTime;
                _context.SaveChanges();
                return true;   
            }
            return false;

        }
    }
}
