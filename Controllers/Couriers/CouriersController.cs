using CourierServiceDotnet.Controllers.Couriers.DTO;
using CourierServiceDotnet.Services.Courier.ServiceLibrary;
using CourierServiceDotnet.Services.Courier.ServiceLibrary.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CourierServiceDotnet.Controllers
{
    [Authorize]
    public class CouriersController : BaseConotroller
    {
        private readonly ICourierServiceLibrary _courierServiceLibrary;
        public CouriersController(ICourierServiceLibrary courierServiceLibrary)
        {
            _courierServiceLibrary = courierServiceLibrary;
        }

        [HttpGet]
        public async Task<IActionResult> GetCouriers()
        {
            var result = await _courierServiceLibrary.GetCouriers();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourier([FromBody] CreateCourierRequest request)
        {
            var newCourier = await _courierServiceLibrary.CreateCourier(new CreateCourierRequestDTO() { Capacity = request.Capacity, Name = request.Name });
            return StatusCode(201, newCourier);
        }
    }
}