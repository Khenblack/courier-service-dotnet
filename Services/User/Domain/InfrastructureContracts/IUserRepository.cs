using CourierServiceDotnet.Services.User.Domain.Entities;
using CourierServiceDotnet.Services.User.Domain.InfrastructureContracts.DTO;
using CourierServiceDotnet.Services.User.Infrastructure.DTO;
using Microsoft.EntityFrameworkCore.Storage;

namespace CourierServiceDotnet.Services.User.Domain.InfrastructureContracts
{
    public interface IUserRepository
    {
        Task<IDbContextTransaction> Transaction();
        IExecutionStrategy CreateExecutionStrategy();

        Task<UserEntity?> GetSingleUserFiltered(UserFilterRequestDTO request);

        Task<UserEntity> CreateUser(CreateUserRequestDTO request);
    }
}