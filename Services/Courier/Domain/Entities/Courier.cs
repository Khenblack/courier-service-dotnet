namespace CourierServiceDotnet.Services.Courier.Domain.Entities
{
    public class CourierEntity
    {
        public int Id { get; set; }
        public int Capacity { get; set; }

        public string Name { get; set; }

        public CourierEntity(int id, int capacity, string name)
        {
            this.Id = id;
            this.Capacity = capacity;
            this.Name = name;
        }
    }
}

