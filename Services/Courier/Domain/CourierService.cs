using CourierServiceDotnet.Services.Courier.Domain.Entities;

namespace CourierServiceDotnet.Services.Courier.Domain
{
    public class CourierService : ICourierService
    {
        public Task<IEnumerable<CourierEntity>> GetCouriers()
        {
            throw new NotImplementedException();
        }
    }

}