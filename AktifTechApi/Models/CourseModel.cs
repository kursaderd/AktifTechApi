using System.ComponentModel.DataAnnotations;

namespace AktifTechApi.Models
{
    public class CourseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Instructor { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public string DifficultyLevel { get; set; }
    }
}
