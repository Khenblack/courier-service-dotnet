namespace CourierServiceDotnet.Services.Courier.Infrastructure.Entities
{
    public class CourierDB
    {
        public int Id { get; set; }
        public int Capacity { get; set; }

        public CourierDB(int id, int capacity)
        {
            this.Id = id;
            this.Capacity = capacity;
        }
    }

}