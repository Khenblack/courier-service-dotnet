namespace CourierServiceDotnet.Services.Courier.ServiceLibrary.DTO
{
    public class CourierDTO
    {
        int Id { get; set; }
        int Capacity { get; set; }

        public CourierDTO(int id, int capacity)
        {
            this.Id = id;
            this.Capacity = capacity;
        }
    }
}