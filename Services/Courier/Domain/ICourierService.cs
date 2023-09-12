

using CourierServiceDotnet.Services.Courier.Domain.Entities;

namespace CourierServiceDotnet.Services.Courier.Domain
{
    public interface ICourierService
    {
        public Task<List<CourierEntity>> GetCouriers();

        public Task<CourierEntity> CreateCourier(string name, int capacity);
    }

}