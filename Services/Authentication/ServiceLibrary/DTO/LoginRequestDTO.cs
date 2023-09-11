namespace CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO
{
    public class LoginRequestDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public LoginRequestDTO(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
    }
}