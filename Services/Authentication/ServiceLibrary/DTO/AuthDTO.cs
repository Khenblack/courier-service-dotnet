namespace CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO
{
    public class AuthDTO
    {
        public int UserId { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public AuthDTO(int UserId, byte[] PasswordHash, byte[] PasswordSalt)
        {
            this.UserId = UserId;
            this.PasswordHash = PasswordHash;
            this.PasswordSalt = PasswordSalt;
        }
    }
}