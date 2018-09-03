using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTO
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }    
        [Required]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "You must specify a password between 6 and 15 characters")]
        public string Password { get; set; }
    }
}