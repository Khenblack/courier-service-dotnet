using CourierServiceDotnet.Services.User.Domain.Entities;

namespace CourierServiceDotnet.Services.User.Domain.InfrastructureContracts
{
    public interface IUserRepository
    {
        Task<UserEntity?> GetUser(int id);
    }
}