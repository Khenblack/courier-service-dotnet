using CourierServiceDotnet.Services.Courier.Domain.Entities;
using CourierServiceDotnet.Services.Courier.Infrastructure.Entities;

namespace CourierServiceDotnet.Services.Courier.Infrastructure.Mappers
{
    public static class EntityMapper
    {
        public static CourierEntity Map(CourierDB courier)
        {
            var entityMapped = new CourierEntity(courier.Id, courier.Capacity, courier.Name);
            return entityMapped;
        }
        public static List<CourierEntity> Map(List<CourierDB> couriers)
        {
            var entityMapped = couriers.ConvertAll(new Converter<CourierDB, CourierEntity>(Map));
            return entityMapped;
        }
    }
}