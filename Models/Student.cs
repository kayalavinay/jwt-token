using System.ComponentModel.DataAnnotations;

namespace JWTToken.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string email { get; set; }
        public long mobile { get; set; }

        public string ProfileImageUrl { get; set; }

        public Guid genderId { get; set; }
    }
}
