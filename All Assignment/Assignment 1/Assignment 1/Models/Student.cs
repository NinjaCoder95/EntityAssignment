using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Assignment_1.Models
{

    public class Student
    {
        [Key]
        public Guid RollNumber { get; set; }
        public string Name { get; set; }
        public int StudentClass { get; set; }
        public int year_of_enrollment { get; set; }

    }
}
