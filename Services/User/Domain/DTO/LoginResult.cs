
namespace CourierServiceDotnet.Services.User.Domain.DTO
{

    public enum LoginErrorResult
    {
        USER_NOT_FOUND,
        PASSWORD_DOESNOT_MATCH
    }
    public class LoginResult
    {
        public bool Valid { get; set; }

        public LoginErrorResult? Reason { get; set; }

        public LoginResult(bool Valid, LoginErrorResult? Reason)
        {
            this.Valid = Valid;
            this.Reason = Reason;
        }

        public LoginResult(bool Valid)
        {
            this.Valid = Valid;
        }
    }

}