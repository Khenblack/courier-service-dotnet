using CourierServiceDotnet.Services.Authentication.Infrastructure.DBEntities;
using CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.Authentication.ServiceLibrary.Contracts
{
    public interface IAuthenticationServiceLibrary
    {
        // Task<LoginResponseDTO> Login(LoginRequestDTO request);

        Task<AuthDTO?> CreateCredentials(int userId, string password);

        Task<bool> ValidateCredentials(int userId, string password);
    }
}