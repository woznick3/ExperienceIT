using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Midterm.Models
{
    public class Course
    {
        [Required]
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string CourseName { get; set; }

        [Required]
        [StringLength(250)]
        public string CourseDescription { get; set; }

        [StringLength(30)]
        [Required]
        public string TutorName { get; set; }

        [Required]
        [Range(1, 10)]
        public int CourseRating { get; set; }
    }
}