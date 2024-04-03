namespace KidsFlixSystem.Web.ViewModels.Home
{
    using System.ComponentModel.DataAnnotations;


    public class LoginViewModel
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
