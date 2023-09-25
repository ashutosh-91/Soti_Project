using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class DoctorSpecialization
    {

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        [ForeignKey("Specialization")]
        public string SpecializationCode { get; set; }
        public DateTime SpecializationDate { get; set; }
    }
}
