using CourierServiceDotnet.Services.User.Domain;
using CourierServiceDotnet.Services.User.Domain.DTO;
using CourierServiceDotnet.Services.User.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.User.ServiceLibrary.DTO;
using CourierServiceDotnet.Services.User.ServiceLibrary.Mappers;

namespace CourierServiceDotnet.Services.User.ServiceLibrary.Implementations
{
    public class UserServiceLibrary : IUserServiceLibrary
    {
        private readonly IUserService _userService;
        public UserServiceLibrary(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UserDTO?> GetUser(int Id)
        {
            var result = await _userService.GetUser(Id);
            if (result == null) return null;
            var resultMapped = EntityMapper.Map(result);
            return resultMapped;
        }

        public async Task<UserDTO?> GetUserByEmail(string email)
        {
            var result = await _userService.GetUserByEmail(email);
            if (result == null) return null;
            var resultMapped = EntityMapper.Map(result);
            return resultMapped;
        }

        public async Task<UserDTO> RegisterUser(UserRegisterRequestDTO request)
        {
            var createdUser = await _userService.RegisterUser(new RegisterUserRequest(request.FirstName, request.LastName, request.Email, request.Password, request.Active));
            var resultMapped = EntityMapper.Map(createdUser);
            return resultMapped;
        }
    }
}