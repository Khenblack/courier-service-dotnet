namespace CourierServiceDotnet.Services.Courier.Domain.Entities
{
    public class CourierEntity
    {
        public int Id { get; set; }
        public int Capacity { get; set; }

        public CourierEntity(int id, int capacity)
        {
            this.Id = id;
            this.Capacity = capacity;
        }
    }
}

