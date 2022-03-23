using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InformationandTechnologyCollege.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required]

        public string Name { get; set; }
        [StringLength(100)]

        public string Description { get; set; }
        public string Code { get; set; }
    }
}