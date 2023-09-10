using CourierServiceDotnet.Services.Courier.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.Courier.ServiceLibrary
{
    public interface ICourierServiceLibrary
    {
        public Task<IEnumerable<CourierDTO>> GetCouriers();
    }

}