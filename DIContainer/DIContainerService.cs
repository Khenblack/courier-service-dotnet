using CourierServiceDotnet.DBContext;
using CourierServiceDotnet.Services.Courier.Domain;
using CourierServiceDotnet.Services.Courier.Domain.InfrastructureContracts;
using CourierServiceDotnet.Services.Courier.Infrastructure;
using CourierServiceDotnet.Services.Courier.ServiceLibrary;
using CourierServiceDotnet.Services.User.Domain;
using CourierServiceDotnet.Services.User.Domain.InfrastructureContracts;
using CourierServiceDotnet.Services.User.Infrastructure;
using CourierServiceDotnet.Services.User.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.User.ServiceLibrary.Implementations;

namespace CourierServiceDotnet.DIContainer
{
    public static class DIContainerService
    {
        public static void RegisterAppDependencies(this IServiceCollection services)
        {
            services.AddDbContext<DataBaseContext>(ServiceLifetime.Transient);
            services.AddTransient<ICourierRepository, CourierRepository>();
            services.AddTransient<ICourierService, CourierService>();
            services.AddTransient<ICourierServiceLibrary, CourierServiceLibrary>();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserServiceLibrary, UserServiceLibrary>();
        }
    }
}