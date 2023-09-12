using CourierServiceDotnet.Services.User.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.User.ServiceLibrary.Contracts
{
    public interface IUserServiceLibrary
    {
        Task<UserDTO?> GetUser(int Id);

        Task<UserDTO?> GetUserByEmail(string email);

        Task<UserDTO> RegisterUser(UserRegisterRequestDTO request);

        Task<LoginResultDTO> LogIn(string email, string password);
    }
}