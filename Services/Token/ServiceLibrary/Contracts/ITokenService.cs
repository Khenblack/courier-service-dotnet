namespace CourierServiceDotnet.Services.Token.ServiceLibrary.Contracts
{
    public interface ITokenService
    {
        string CreateToken(int userId);
    }
}