using CourierServiceDotnet.Services.Courier.Domain.Entities;
using CourierServiceDotnet.Services.Courier.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.Courier.ServiceLibrary.Mappers
{
    public static class Mapper
    {
        public static CourierDTO Map(CourierEntity courier)
        {
            var entityMapped = new CourierDTO(courier.Id, courier.Capacity, courier.Name);
            return entityMapped;
        }
        public static List<CourierDTO> Map(List<CourierEntity> couriers)
        {
            var entityMapped = couriers.ConvertAll(new Converter<CourierEntity, CourierDTO>(Map));
            return entityMapped;
        }
    }

}