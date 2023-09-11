using CourierServiceDotnet.Services.Courier.Infrastructure.Mappers;
using CourierServiceDotnet.Services.User.Domain.DTO;
using CourierServiceDotnet.Services.User.Domain.Entities;
using CourierServiceDotnet.Services.User.Domain.Exceptions;
using CourierServiceDotnet.Services.User.Domain.InfrastructureContracts;
using CourierServiceDotnet.Services.User.Domain.InfrastructureContracts.DTO;
using CourierServiceDotnet.Services.User.Infrastructure.DTO;

namespace CourierServiceDotnet.Services.User.Domain
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserEntity?> GetUser(int id)
        {
            var result = await _userRepository.GetSingleUserFiltered(new UserFilterRequestDTO() { Id = id });
            return result;
        }

        public async Task<UserEntity?> GetUserByEmail(string email)
        {
            var result = await _userRepository.GetSingleUserFiltered(new UserFilterRequestDTO() { Email = email });
            return result;
        }

        public async Task<UserEntity> RegisterUser(RegisterUserRequest request)
        {
            var user = await _userRepository.GetSingleUserFiltered(new UserFilterRequestDTO { Email = request.Email });
            if (user != null) throw new UserAlreadyExsistsException(string.Format("User with email {0} already exists", request.Email));
            var createdUser = await _userRepository.CreateUser(new CreateUserRequestDTO { Email = request.Email, FirstName = request.FirstName, LastName = request.LastName, Active = request.Active });
            return createdUser;
        }
    }
}