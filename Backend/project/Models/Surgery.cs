using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models
{
    public class ISurgery
    {
        [Key]
        public int SurgeryId { get; set; }
        
       
        public int? DoctorId { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal EndTime { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal StartTime { get; set; }       
        public string SurgeryCategory { get; set; }
        public DateTime SurgeryDate { get; set; }

    }
}
