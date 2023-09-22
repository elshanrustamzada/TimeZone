using System.ComponentModel.DataAnnotations;

namespace TimeZone.ViewModels
{
    public class LoginVM
    {

        [Required(ErrorMessage = "It cannot be empty!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "It cannot be empty!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsRemember { get; set; }
    }
}
