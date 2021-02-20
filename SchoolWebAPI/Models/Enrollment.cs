using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SchoolWebAPI.Models
{
    public class Enrollment
    {
        public int studentId { get; set; }
        [JsonIgnore]
        public Student student{ get; set; }
        public int courseId { get; set; }
        [JsonIgnore]
        public Course course { get; set; }
    }
}
