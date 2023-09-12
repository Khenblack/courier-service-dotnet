using CourierServiceDotnet.Services.Authentication.Domain.Entities;
using CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.Authentication.ServiceLibrary.Mapper
{
    public static class EntityMapper
    {
        public static AuthDTO Map(Auth auth)
        {
            var entityMapped = new AuthDTO(auth.UserId, auth.PasswordHash, auth.PasswordSalt);
            return entityMapped;
        }
        public static List<AuthDTO> Map(List<Auth> users)
        {
            var entityMapped = users.ConvertAll(new Converter<Auth, AuthDTO>(Map));
            return entityMapped;
        }
    }
}