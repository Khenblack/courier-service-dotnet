namespace CourierServiceDotnet.Services.Courier.ServiceLibrary.DTO
{
    public class CourierDTO
    {
        public int Id { get; set; }
        public int Capacity { get; set; }

        public CourierDTO(int id, int capacity)
        {
            this.Id = id;
            this.Capacity = capacity;
        }
    }
}