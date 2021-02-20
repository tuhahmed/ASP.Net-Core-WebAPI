using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPI.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        public Student students{ get; set; }
        public Course courses{ get; set; }
}
}
