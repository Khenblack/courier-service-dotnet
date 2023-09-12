using CourierServiceDotnet.Services.User.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.User.ServiceLibrary.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CourierServiceDotnet.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseController : Controller
    {
        private readonly IUserServiceLibrary _userServiceLibrary;
        protected BaseController(IUserServiceLibrary userServiceLibrary)
        {
            _userServiceLibrary = userServiceLibrary;
        }

        protected async Task<UserDTO?> getUserFromAuth()
        {
            var userId = User.FindFirst("userId")?.Value;
            if (userId == null) return null;
            var user = await this._userServiceLibrary.GetUser(int.Parse(userId));
            return user;
        }
    }
}