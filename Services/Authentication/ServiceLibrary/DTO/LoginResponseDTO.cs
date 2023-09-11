
namespace CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO
{
    public enum ReasonEnumDTO
    {
        USER_NOT_FOUND,
        INVALID_PASSWORD
    }
    public class LoginResponseDTO
    {
        public bool IsValid { get; set; }
        public ReasonEnumDTO? Reason { get; set; }

        public LoginResponseDTO(bool isValid, ReasonEnumDTO? Reason)
        {
            this.IsValid = isValid;
            this.Reason = Reason;
        }
    }
}