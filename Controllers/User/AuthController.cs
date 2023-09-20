
using CourierServiceDotnet.Controllers.User.DTO;
using CourierServiceDotnet.Services.Token.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.Token.ServiceLibrary.Contracts.DTO;
using CourierServiceDotnet.Services.User.Domain.Exceptions;
using CourierServiceDotnet.Services.User.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.User.ServiceLibrary.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CourierServiceDotnet.Controllers.User
{
    [Authorize]
    public class UserController : BaseController
    {
        private readonly IUserServiceLibrary _userServiceLibrary;
        private readonly ITokenService _tokenService;
        public UserController(IUserServiceLibrary userServiceLibrary, ITokenService tokenService) : base(userServiceLibrary)
        {
            _userServiceLibrary = userServiceLibrary;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<ActionResult<UserDTO>> RegisterUser([FromBody] UserRegistrationRequestDTO request)
        {
            try
            {
                if (request.Password != request.PasswordConfirm) return StatusCode(400, new { message = "Paswords does not match" });
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

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<TokenDTO>> Login([FromBody] UserLoginRequestDTO userLoginRequestDTO)
        {
            var user = await _userServiceLibrary.GetUserByEmail(userLoginRequestDTO.Email);
            if (user == null) return NotFound(new { message = "User not found" });
            var loginResponse = await _userServiceLibrary.LogIn(userLoginRequestDTO.Email, userLoginRequestDTO.Password);
            if (!loginResponse.Valid)
            {
                switch (loginResponse.Reason)
                {
                    case LoginErrorResultDTO.USER_NOT_FOUND:
                        return NotFound(new { message = "User not found" });
                    case LoginErrorResultDTO.PASSWORD_DOESNOT_MATCH:
                        return BadRequest(new { message = "Invalid credentials" });
                    default:
                        return StatusCode(500, new { message = "Internal server error" });
                }
            }

            var token = loginResponse.Valid ? _tokenService.CreateToken(user.Id) : null;

            return Ok(token);
        }

    }
}