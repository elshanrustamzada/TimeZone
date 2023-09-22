using System.ComponentModel.DataAnnotations;

namespace TimeZone.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "It cannot be empty!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "It cannot be empty!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "It cannot be empty!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "It cannot be empty!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "It cannot be empty!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "It cannot be empty!")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string CheckPassword { get; set; }
        public bool IsRemember { get; set; }
    }
}
