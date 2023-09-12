using CourierServiceDotnet.Services.Authentication.Domain.Entities;
using CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.Domain.Contracts
{
    public interface IAuthenticationService
    {
        Task<Auth> CreateAuth(int userId, string password, string appPasswordKey);

        Task<bool> ValidateCredentials(int userId, string password, string appPasswordKey);
    }
}