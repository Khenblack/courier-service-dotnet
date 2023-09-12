using System.ComponentModel.DataAnnotations;

namespace CourierServiceDotnet.Controllers.User.DTO
{
    public class UserLoginRequestDTO
    {

        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public UserLoginRequestDTO(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
    }
}