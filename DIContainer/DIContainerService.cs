using CourierServiceDotnet.DBContext;
using CourierServiceDotnet.Services.Authentication.Domain.Implementations;
using CourierServiceDotnet.Services.Authentication.Domain.InfrastructureContracts;
using CourierServiceDotnet.Services.Authentication.Infrastructure;
using CourierServiceDotnet.Services.Authentication.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.Authentication.ServiceLibrary.Implementations;
using CourierServiceDotnet.Services.Courier.Domain;
using CourierServiceDotnet.Services.Courier.Domain.InfrastructureContracts;
using CourierServiceDotnet.Services.Courier.Infrastructure;
using CourierServiceDotnet.Services.Courier.ServiceLibrary;
using CourierServiceDotnet.Services.Domain.Contracts;
using CourierServiceDotnet.Services.Token.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.Token.ServiceLibrary.Implementations;
using CourierServiceDotnet.Services.User.Domain;
using CourierServiceDotnet.Services.User.Domain.InfrastructureContracts;
using CourierServiceDotnet.Services.User.Infrastructure;
using CourierServiceDotnet.Services.User.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.User.ServiceLibrary.Implementations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CourierServiceDotnet.DIContainer
{
    public static class DIContainerService
    {
        public static void RegisterAppDependencies(this IServiceCollection services)
        {
            services.AddDbContext<DataBaseContext>(ServiceLifetime.Transient);

            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<ICourierRepository, CourierRepository>();
            services.AddTransient<ICourierService, CourierService>();
            services.AddTransient<ICourierServiceLibrary, CourierServiceLibrary>();

            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IAuthenticationServiceLibrary, AuthenticationServiceLibrary>();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserServiceLibrary, UserServiceLibrary>();
        }
    }
}