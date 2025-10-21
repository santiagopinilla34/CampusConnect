using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampusConnect.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        // Foreign Keys
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Course Course { get; set; }

        // Optional: grade or status
        public string Grade { get; set; }
    }
}