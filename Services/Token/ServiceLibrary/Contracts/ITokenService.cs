using CourierServiceDotnet.Services.Token.ServiceLibrary.Contracts.DTO;

namespace CourierServiceDotnet.Services.Token.ServiceLibrary.Contracts
{
    public interface ITokenService
    {
        TokenDTO CreateToken(int userId);
    }
}