namespace CourierServiceDotnet
{
    public class AppConfiguration
    {
        public string PasswordKey { get; set; } = string.Empty;
        public string TokenKey { get; set; } = string.Empty;

        public AppConfiguration(string PasswordKey, string TokenKey)
        {
            this.PasswordKey = PasswordKey;
            this.TokenKey = TokenKey;
        }

        public AppConfiguration() { }
    }
}