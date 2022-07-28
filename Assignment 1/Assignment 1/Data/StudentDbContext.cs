using Assignment_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
