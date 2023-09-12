using CourierServiceDotnet.Services.Courier.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.Courier.ServiceLibrary
{
    public interface ICourierServiceLibrary
    {
        public Task<List<CourierDTO>> GetCouriers();

        public Task<CourierDTO> CreateCourier(CreateCourierRequestDTO request);
    }

}