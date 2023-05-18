using System.ComponentModel.DataAnnotations;

namespace UserInformation.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public DateTime Dob { get; set; }

        [MaxLength(10)]
        public int Contact { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }

    }
}
