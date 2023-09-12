
using CourierServiceDotnet.Services.Authentication.Domain.Entities;
using CourierServiceDotnet.Services.Authentication.Infrastructure.DBEntities;

namespace CourierServiceDotnet.Services.Authentication.Infrastructure.Mappers
{
    public static class EntityMapper
    {
        public static Auth Map(AuthDB auth)
        {
            var entityMapped = new Auth(auth.UserId, auth.PasswordHash, auth.PasswordSalt);
            return entityMapped;
        }
        public static List<Auth> Map(List<AuthDB> users)
        {
            var entityMapped = users.ConvertAll(new Converter<AuthDB, Auth>(Map));
            return entityMapped;
        }
    }
}