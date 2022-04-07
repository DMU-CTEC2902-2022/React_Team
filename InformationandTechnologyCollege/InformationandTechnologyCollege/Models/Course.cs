using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InformationandTechnologyCollege.Models
{
    public class Course
    {
        [Required]
        public int CourseId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        

        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }
    }
}