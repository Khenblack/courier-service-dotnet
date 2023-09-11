using CourierServiceDotnet.Services.User.Domain.Entities;
using CourierServiceDotnet.Services.User.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.User.ServiceLibrary.Mappers
{
    public static class EntityMapper
    {
        public static UserDTO Map(UserEntity user)
        {
            var entityMapped = new UserDTO(user.Id, user.FirstName, user.LastName, user.Email, user.Active);
            return entityMapped;
        }
        public static List<UserDTO> Map(List<UserEntity> users)
        {
            var entityMapped = users.ConvertAll(new Converter<UserEntity, UserDTO>(Map));
            return entityMapped;
        }
    }
}