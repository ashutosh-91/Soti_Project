using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Specialization
    {
        [Key]
        [MinLength(3, ErrorMessage = "SpecializationCode should be 3 characters long")]
        [MaxLength(3, ErrorMessage = "SpecializationCode should be 3 characters long")]
        public string SpecializationCode { get; set; }

        [Required(ErrorMessage = "SpecializationName is required")]
        [MaxLength(50, ErrorMessage = "SpecializationName should not be longer than 50 charatacters")]
        public string SpecializationName { get; set; }
    }
}
