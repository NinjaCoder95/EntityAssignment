using Assignment_1.Data;
using Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly StudentDbContext dbContext;

        public StudentController(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public async Task<IActionResult> GetStudentDetails()
        {
            return Ok(await dbContext.Students.ToListAsync());
            
        }

        [HttpPost]
        public async Task<IActionResult> AddStudentInfo(AddStudent addStudent)
        {
            var student = new Student()
            {
                RollNumber = Guid.NewGuid(),
                Name = addStudent.Name,
                StudentClass = addStudent.StudentClass
            };

            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();

            return Ok(student);
        }

    }
}
