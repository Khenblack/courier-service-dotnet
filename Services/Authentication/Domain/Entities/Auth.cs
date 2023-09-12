using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourierServiceDotnet.Services.Authentication.Domain.Entities
{
    public class Auth
    {
        public int UserId { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public Auth(int UserId, byte[] PasswordHash, byte[] PasswordSalt)
        {
            this.UserId = UserId;
            this.PasswordHash = PasswordHash;
            this.PasswordSalt = PasswordSalt;
        }
    }
}