using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourierServiceDotnet.Services.Courier.Infrastructure.Entities
{
    public class CourierDB
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public int Capacity { get; set; }

        public CourierDB(int id, int capacity)
        {
            this.Id = id;
            this.Capacity = capacity;
        }
    }

}