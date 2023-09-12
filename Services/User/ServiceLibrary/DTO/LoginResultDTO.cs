namespace CourierServiceDotnet.Services.User.ServiceLibrary.DTO
{
    public enum LoginErrorResultDTO
    {
        USER_NOT_FOUND,
        PASSWORD_DOESNOT_MATCH
    }
    public class LoginResultDTO
    {
        public bool Valid { get; set; }

        public LoginErrorResultDTO? Reason { get; set; }

        public LoginResultDTO(bool Valid, LoginErrorResultDTO? Reason)
        {
            this.Valid = Valid;
            this.Reason = Reason;
        }
    }
}