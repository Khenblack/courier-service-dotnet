using Microsoft.AspNetCore.Mvc;

namespace CourierServiceDotnet.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseConotroller : Controller
    {

    }
}