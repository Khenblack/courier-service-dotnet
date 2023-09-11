using CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.Authentication.ServiceLibrary.Contracts
{
    public interface IAuthenticationServiceLibrary
    {
        Task<LoginResponseDTO> Login(LoginRequestDTO request);
    }
}