

using CourierServiceDotnet.Services.Courier.Domain.Entities;

namespace CourierServiceDotnet.Services.Courier.Domain
{
    public interface ICourierService
    {
        public Task<IEnumerable<CourierEntity>> GetCouriers();
    }

}