using Microsoft.EntityFrameworkCore;

namespace Assignment_1.Models
{
    [Keyless]
    public class AddStudent
    {
        public string Name { get; set; }
        public int StudentClass { get; set; }
    }
}
