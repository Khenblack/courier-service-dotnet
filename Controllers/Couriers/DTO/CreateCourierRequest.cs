using System.ComponentModel.DataAnnotations;

namespace CourierServiceDotnet.Controllers.Couriers.DTO
{
    public class CreateCourierRequest
    {
        [Required]
        public int Capacity { get; set; }
        [Required, MinLength(3)]
        public string Name { get; set; } = string.Empty;
    }
}