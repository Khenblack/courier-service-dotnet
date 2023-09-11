using CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO;
using CourierServiceDotnet.Services.Domain.Contracts;

namespace CourierServiceDotnet.Services.Authentication.Domain.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        public Task<LoginResponseDTO> Login(string Email, string Password)
        {
            throw new NotImplementedException();
        }
    }
}