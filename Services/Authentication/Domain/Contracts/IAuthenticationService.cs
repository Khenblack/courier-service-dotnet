using CourierServiceDotnet.Services.Authentication.Domain.Entities;
using CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.Domain.Contracts
{
    public interface IAuthenticationService
    {
        Task<LoginResponseDTO> Login(int userId, string password);

        Task<Auth> CreateAuth(int userId, string password, string appPasswordKey);
    }
}