using CourierServiceDotnet.Services.Authentication.Domain.Enums;

namespace CourierServiceDotnet.Services.Authentication.Domain.Entities
{
    public class LoginResponse
    {
        public bool IsValid { get; set; }
        public ReasonEnum? Reason { get; set; }

        public LoginResponse(bool isValid, ReasonEnum? Reason)
        {
            this.IsValid = isValid;
            this.Reason = Reason;
        }
    }
}