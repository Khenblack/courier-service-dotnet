using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourierServiceDotnet.Services.User.Domain.Exceptions
{
    public class UserAlreadyExsistsException : Exception
    {
        public UserAlreadyExsistsException(string? message) : base(message)
        {

        }
    }
}