namespace CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO
{
    public class LoginRequestDTO
    {
        public int UserId { get; set; }
        public string Password { get; set; }

        public LoginRequestDTO(int UserId, string Password)
        {
            this.UserId = UserId;
            this.Password = Password;
        }
    }
}