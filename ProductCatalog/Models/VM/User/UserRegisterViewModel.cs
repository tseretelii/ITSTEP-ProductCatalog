using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models.VM.User
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "აუცილებელი ველი")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "აუცილებელი ველი")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "აუცილებელი ველი")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "აუცილებელი ველი")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }


        [Required(ErrorMessage = "აუცილებელი ველი")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
