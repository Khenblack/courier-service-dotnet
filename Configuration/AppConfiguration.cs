
namespace CourierServiceDotnet.Configuration
{
    public class AppConfiguration
    {
        public string PasswordKey { get; set; } = string.Empty;

        public string TokenKey { get; set; } = string.Empty;
        public AppConfiguration() { }
    }
}