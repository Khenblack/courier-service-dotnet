using CourierServiceDotnet.Services.Courier.Domain;
using CourierServiceDotnet.Services.Courier.ServiceLibrary.DTO;
using CourierServiceDotnet.Services.Courier.ServiceLibrary.Mappers;

namespace CourierServiceDotnet.Services.Courier.ServiceLibrary
{
    public class CourierServiceLibrary : ICourierServiceLibrary
    {
        private readonly ICourierService _courierService;

        public CourierServiceLibrary(ICourierService courierService)
        {
            _courierService = courierService;
        }
        public async Task<List<CourierDTO>> GetCouriers()
        {
            var result = await _courierService.GetCouriers();
            var resultMapped = Mapper.Map(result);
            return resultMapped;
        }
    }
}