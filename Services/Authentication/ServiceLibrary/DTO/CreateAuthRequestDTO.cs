using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO
{
    public class CreateAuthRequestDTO
    {
        public int UserId { get; set; }
        public string Password { get; set; }

        public CreateAuthRequestDTO(int UserId, string Password)
        {
            this.UserId = UserId;
            this.Password = Password;
        }
    }
}