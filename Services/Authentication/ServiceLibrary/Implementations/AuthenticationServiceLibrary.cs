using CourierServiceDotnet.Services.Authentication.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.Authentication.ServiceLibrary.Implementations
{
    public class AuthenticationServiceLibrary : IAuthenticationServiceLibrary
    {
        public Task<LoginResponseDTO> Login(LoginRequestDTO request)
        {
            throw new NotImplementedException();
        }
    }
}