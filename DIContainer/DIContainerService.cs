using CourierServiceDotnet.DBContext;
using CourierServiceDotnet.Services.Courier.Domain;
using CourierServiceDotnet.Services.Courier.Domain.InfrastructureContracts;
using CourierServiceDotnet.Services.Courier.Infrastructure;
using CourierServiceDotnet.Services.Courier.ServiceLibrary;

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
        }
    }
}