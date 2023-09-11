namespace CourierServiceDotnet.Services.User.Domain.DTO
{
    public class RegisterUserRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        public RegisterUserRequest(string FirstName, string LastName, string Email, string Password, bool Active)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
            this.Active = Active;
        }

    }
}