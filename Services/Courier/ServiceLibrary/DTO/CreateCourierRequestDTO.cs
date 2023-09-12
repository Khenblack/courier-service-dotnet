namespace CourierServiceDotnet.Services.Courier.ServiceLibrary.DTO
{
    public class CreateCourierRequestDTO
    {
        public int Capacity { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}