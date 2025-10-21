using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

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
        [ValidateNever]
        public Student Student { get; set; }
        [ValidateNever]
        public Course Course { get; set; }

        public int? Grade { get; set; }
    }
}