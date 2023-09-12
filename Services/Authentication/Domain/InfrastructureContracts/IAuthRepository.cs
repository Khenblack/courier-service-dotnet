using CourierServiceDotnet.Services.Authentication.Domain.Entities;

namespace CourierServiceDotnet.Services.Authentication.Domain.InfrastructureContracts
{
    public interface IAuthRepository
    {
        Task<Auth?> GetAuthByUser(int userId);

        Task<Auth> CreateAuth(int userId, byte[] passwordHash, byte[] passwordSalt);
    }
}