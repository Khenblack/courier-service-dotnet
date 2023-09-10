using CourierServiceDotnet.Services.Courier.ServiceLibrary.DTO;

namespace CourierServiceDotnet.Services.Courier.ServiceLibrary
{
    public class CourierServiceLibrary : ICourierServiceLibrary
    {
        public async Task<IEnumerable<CourierDTO>> GetCouriers()
        {
            var result = new List<CourierDTO>() { new CourierDTO(1, 30) };
            return result;
        }
    }
}