using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CourierServiceDotnet.Services.Token.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.Token.ServiceLibrary.Contracts.DTO;
using Microsoft.IdentityModel.Tokens;

namespace CourierServiceDotnet.Services.Token.ServiceLibrary.Implementations
{
    public class TokenService : ITokenService
    {
        private readonly AppConfiguration _appConfiguration;
        public TokenService(AppConfiguration appConfiguration)
        {
            _appConfiguration = appConfiguration;
        }
        public TokenDTO CreateToken(int userId)
        {
            Claim[] claims = new Claim[] { new Claim("userId", userId.ToString()) };

            SymmetricSecurityKey tokenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appConfiguration.TokenKey));
            SigningCredentials credentials = new SigningCredentials(tokenKey, SecurityAlgorithms.HmacSha512Signature);

            SecurityTokenDescriptor descriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                SigningCredentials = credentials,
                Expires = DateTime.Now.AddDays(7)
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            SecurityToken token = tokenHandler.CreateToken(descriptor);

            var tokenDto = new TokenDTO(tokenHandler.WriteToken(token));
            return tokenDto;
        }
    }
}