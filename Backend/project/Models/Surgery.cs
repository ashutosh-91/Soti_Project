using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class ISurgery
    {
        [Key]
       public int? DoctorId { get; set; }
       public decimal EndTime { get; set; }
       public decimal StartTime { get; set; }
        public int SurgeryId { get; set; }
        public string SurgeryCategory { get; set; }
        public DateTime SurgeryDate { get; set; }

    }
}
