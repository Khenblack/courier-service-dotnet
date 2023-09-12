using CourierServiceDotnet.Services.Authentication.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO;
using CourierServiceDotnet.Services.Authentication.ServiceLibrary.Mapper;
using CourierServiceDotnet.Services.Domain.Contracts;

namespace CourierServiceDotnet.Services.Authentication.ServiceLibrary.Implementations
{
    public class AuthenticationServiceLibrary : IAuthenticationServiceLibrary
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly AppConfiguration _appConfiguration;
        public AuthenticationServiceLibrary(IAuthenticationService authenticationService, AppConfiguration appConfiguration)
        {
            _authenticationService = authenticationService;
            _appConfiguration = appConfiguration;
        }

        public async Task<AuthDTO?> CreateCredentials(int userId, string password)
        {
            var result = await _authenticationService.CreateAuth(userId, password, _appConfiguration.PasswordKey);
            var resultMapped = EntityMapper.Map(result);
            return resultMapped;
        }

        public async Task<bool> ValidateCredentials(int userId, string password)
        {
            var result = await _authenticationService.ValidateCredentials(userId, password, _appConfiguration.PasswordKey);
            return result;
        }
    }
}