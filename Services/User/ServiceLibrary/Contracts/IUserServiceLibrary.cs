using CourierServiceDotnet.Services.User.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.User.ServiceLibrary.Contracts
{
    public interface IUserServiceLibrary
    {
        Task<UserDTO?> GetUser(int Id);
    }
}