using System.Security.Cryptography;
using System.Text;
using CourierServiceDotnet.Services.Authentication.Domain.Entities;
using CourierServiceDotnet.Services.Authentication.Domain.InfrastructureContracts;
using CourierServiceDotnet.Services.Authentication.ServiceLibrary.DTO;
using CourierServiceDotnet.Services.Domain.Contracts;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace CourierServiceDotnet.Services.Authentication.Domain.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthRepository _authRepository;
        public AuthenticationService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<Auth> CreateAuth(int userId, string password, string appPasswordKey)
        {
            var passwordSalt = GeneratePasswordSalt();
            var passwordHash = GetPasswordHash(password, passwordSalt, appPasswordKey);
            var result = await _authRepository.CreateAuth(userId, passwordHash, passwordSalt);
            return result;

        }

        public async Task<bool> ValidateCredentials(int userId, string password, string appPasswordKey)
        {
            var userAuth = await _authRepository.GetAuthByUser(userId);
            if (userAuth == null) return false;

            var passwordHash = GetPasswordHash(password, userAuth.PasswordSalt, appPasswordKey);

            return passwordHash.SequenceEqual(userAuth.PasswordHash);
        }

        private byte[] GeneratePasswordSalt()
        {
            byte[] passwordSalt = new byte[256 / 8];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
                rng.GetNonZeroBytes(passwordSalt);
            return passwordSalt;
        }

        private byte[] GetPasswordHash(string password, byte[] passwordSalt, string AppPasswordKey)
        {
            string passwordSaltPlusString = AppPasswordKey + Convert.ToBase64String(passwordSalt);

            byte[] passwordHash = KeyDerivation.Pbkdf2(
                password: password,
                salt: Encoding.ASCII.GetBytes(passwordSaltPlusString),
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8
            );
            return passwordHash;
        }

    }
}