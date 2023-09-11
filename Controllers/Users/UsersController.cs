
using CourierServiceDotnet.Controllers.Users.DTO;
using CourierServiceDotnet.Services.User.Domain.Exceptions;
using CourierServiceDotnet.Services.User.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.User.ServiceLibrary.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CourierServiceDotnet.Controllers.Users
{
    public class UsersController : BaseConotroller
    {
        private readonly IUserServiceLibrary _userServiceLibrary;
        public UsersController(IUserServiceLibrary userServiceLibrary)
        {
            _userServiceLibrary = userServiceLibrary;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationRequestDTO request)
        {
            try
            {
                var requestMapped = new UserRegisterRequestDTO(request.FirstName, request.LastName, request.Email, request.Password, true);
                var createdUser = await _userServiceLibrary.RegisterUser(requestMapped);
                Response.StatusCode = 201;
                return Ok(createdUser);
            }
            catch (UserAlreadyExsistsException e)
            {
                return StatusCode(400, new { message = e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { message = e.Message });
            }

        }

    }
}