using CourierServiceDotnet.Services.User.Domain.DTO;
using CourierServiceDotnet.Services.User.Domain.Entities;
using CourierServiceDotnet.Services.User.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.User.ServiceLibrary.Mappers
{
    public static class LoginResponseMapper
    {
        public static LoginResultDTO Map(LoginResult login)
        {
            var entityMapped = new LoginResultDTO(login.Valid, login.Reason != null ? (LoginErrorResultDTO)login.Reason : null);
            return entityMapped;
        }
    }
}