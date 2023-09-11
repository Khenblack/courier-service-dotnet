using CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.Domain.Contracts
{
    public interface IAuthenticationService
    {
        Task<LoginResponseDTO> Login(string Email, string Password);
    }
}