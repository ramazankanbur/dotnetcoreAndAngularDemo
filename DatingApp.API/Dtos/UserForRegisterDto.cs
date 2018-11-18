using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "username is required")]
        public string Username { get; set; }


        [Required(ErrorMessage = "pasword is required")]
        [StringLength(8, MinimumLength=4, ErrorMessage="you must specfy password between 4 and 8")]
        public string Password { get; set; }
    }
}