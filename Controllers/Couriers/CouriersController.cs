using CourierServiceDotnet.Services.Courier.ServiceLibrary;
using Microsoft.AspNetCore.Mvc;

namespace CourierServiceDotnet.Controllers
{
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

    }
}