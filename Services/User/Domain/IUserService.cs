using CourierServiceDotnet.Services.User.Domain.DTO;
using CourierServiceDotnet.Services.User.Domain.Entities;

namespace CourierServiceDotnet.Services.User.Domain
{
    public interface IUserService
    {
        Task<UserEntity?> GetUser(int id);

        Task<UserEntity?> GetUserByEmail(string email);

        Task<UserEntity> RegisterUser(RegisterUserRequest request);
    }
}