using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPI.Models
{
    public class Student
    {
        
        public int studentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
       public ICollection<Enrollment> Enrollment { get; set; }
    }
}
