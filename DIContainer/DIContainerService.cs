using CourierServiceDotnet.Services.Courier.ServiceLibrary;

namespace CourierServiceDotnet.DIContainer
{
    public static class DIContainerService
    {
        public static void RegisterAppDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICourierServiceLibrary, CourierServiceLibrary>();
        }
    }
}