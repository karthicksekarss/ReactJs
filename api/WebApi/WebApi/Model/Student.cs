using System.ComponentModel.DataAnnotations;

namespace WebApi.Model
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string? StudentId { get; set; }
        public string? StudentName { get; set; }
        public DateTime? DateOfJoining { get; set; }
    }
}
