using System.ComponentModel.DataAnnotations;

namespace CampusConnect.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [StringLength(20)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Instructor { get; set; }

        public int StudentsEnrolled { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}