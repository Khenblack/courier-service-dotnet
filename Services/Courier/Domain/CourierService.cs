using CourierServiceDotnet.Services.Courier.Domain.Entities;
using CourierServiceDotnet.Services.Courier.Domain.InfrastructureContracts;

namespace CourierServiceDotnet.Services.Courier.Domain
{
    public class CourierService : ICourierService
    {
        private readonly ICourierRepository _courierRepository;
        public CourierService(ICourierRepository courierRepository)
        {
            _courierRepository = courierRepository;
        }

        public async Task<List<CourierEntity>> GetCouriers()
        {
            var result = await _courierRepository.GetCouriers();
            return result;
        }

        public async Task<CourierEntity> CreateCourier(string name, int capacity)
        {
            var result = await _courierRepository.CreateCourier(name, capacity);
            return result;
        }
    }

}