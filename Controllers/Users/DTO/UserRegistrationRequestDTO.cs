using System.ComponentModel.DataAnnotations;

namespace CourierServiceDotnet.Controllers.Users.DTO
{
    public partial class UserRegistrationRequestDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordConfirm { get; set; }

        [Required, MinLength(3)]
        public string FirstName { get; set; }
        [Required, MinLength(3)]
        public string LastName { get; set; }

        public UserRegistrationRequestDTO(string Email, string Password, string PasswordConfirm, string FirstName, string LastName)
        {
            this.Email = Email;
            this.Password = Password;
            this.PasswordConfirm = PasswordConfirm;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }

}