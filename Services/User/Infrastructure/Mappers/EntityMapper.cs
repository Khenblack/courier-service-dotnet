using CourierServiceDotnet.Services.User.Domain.Entities;
using CourierServiceDotnet.Services.User.Infrastructure.DBEntities;

namespace CourierServiceDotnet.Services.User.Infrastructure.Mappers
{
    public static class EntityMapper
    {
        public static UserEntity Map(UserDB user)
        {
            var entityMapped = new UserEntity(user.Id, user.FirstName, user.LastName, user.Email, user.Active);
            return entityMapped;
        }
        public static List<UserEntity> Map(List<UserDB> users)
        {
            var entityMapped = users.ConvertAll(new Converter<UserDB, UserEntity>(Map));
            return entityMapped;
        }
    }
}