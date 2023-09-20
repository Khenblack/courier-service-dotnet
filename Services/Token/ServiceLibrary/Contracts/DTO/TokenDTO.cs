using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourierServiceDotnet.Services.Token.ServiceLibrary.Contracts.DTO
{
    public class TokenDTO
    {
        string Token { get; set; }

        public TokenDTO(string token)
        {
            Token = token;
        }
    }
}