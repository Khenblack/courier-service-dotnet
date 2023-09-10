using CourierServiceDotnet.Services.Courier.Domain.Entities;

namespace CourierServiceDotnet.Services.Courier.Domain.InfrastructureContracts
{
    public interface ICourierRepository
    {
        public Task<IEnumerable<CourierEntity>> GetCouriers();
    }

}