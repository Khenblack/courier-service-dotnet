using CourierServiceDotnet.Controllers.Couriers.DTO;
using CourierServiceDotnet.Services.Courier.ServiceLibrary;
using CourierServiceDotnet.Services.Courier.ServiceLibrary.DTO;
using CourierServiceDotnet.Services.User.ServiceLibrary.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CourierServiceDotnet.Controllers
{
    [Authorize]
    public class CouriersController : BaseController
    {
        private readonly ICourierServiceLibrary _courierServiceLibrary;
        public CouriersController(ICourierServiceLibrary courierServiceLibrary, IUserServiceLibrary userServiceLibrary) : base(userServiceLibrary)
        {
            _courierServiceLibrary = courierServiceLibrary;
        }

        [HttpGet]
        public async Task<IActionResult> GetCouriers()
        {
            var userLogged = await getUserFromAuth();
            if (userLogged != null) Console.WriteLine("User logged is {0}", userLogged.FullName);
            var result = await _courierServiceLibrary.GetCouriers();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourier([FromBody] CreateCourierRequest request)
        {
            var userLogged = await getUserFromAuth();
            if (userLogged != null) Console.WriteLine("User logged is {0}", userLogged.FullName);
            var newCourier = await _courierServiceLibrary.CreateCourier(new CreateCourierRequestDTO() { Capacity = request.Capacity, Name = request.Name });
            return StatusCode(201, newCourier);
        }
    }
}