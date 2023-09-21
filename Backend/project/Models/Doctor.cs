using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class IDoctor
    {
        [Key]
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
    }
}
