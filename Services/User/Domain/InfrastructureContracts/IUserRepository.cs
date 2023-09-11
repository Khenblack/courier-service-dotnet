using CourierServiceDotnet.Services.User.Domain.Entities;
using CourierServiceDotnet.Services.User.Domain.InfrastructureContracts.DTO;
using CourierServiceDotnet.Services.User.Infrastructure.DTO;

namespace CourierServiceDotnet.Services.User.Domain.InfrastructureContracts
{
    public interface IUserRepository
    {
        Task<UserEntity?> GetSingleUserFiltered(UserFilterRequestDTO request);

        Task<UserEntity> CreateUser(CreateUserRequestDTO request);
    }
}