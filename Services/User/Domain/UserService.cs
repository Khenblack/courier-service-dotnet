using CourierServiceDotnet.Services.Authentication.ServiceLibrary.Contracts;
using CourierServiceDotnet.Services.Courier.Infrastructure.Mappers;
using CourierServiceDotnet.Services.User.Domain.DTO;
using CourierServiceDotnet.Services.User.Domain.Entities;
using CourierServiceDotnet.Services.User.Domain.Exceptions;
using CourierServiceDotnet.Services.User.Domain.InfrastructureContracts;
using CourierServiceDotnet.Services.User.Domain.InfrastructureContracts.DTO;
using CourierServiceDotnet.Services.User.Infrastructure.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CourierServiceDotnet.Services.User.Domain
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthenticationServiceLibrary _authenticationServiceLibrary;
        public UserService(IUserRepository userRepository, IAuthenticationServiceLibrary authenticationServiceLibrary)
        {
            _userRepository = userRepository;
            _authenticationServiceLibrary = authenticationServiceLibrary;
        }

        public async Task<UserEntity?> GetUser(int id)
        {
            var result = await _userRepository.GetSingleUserFiltered(new UserFilterRequestDTO() { Id = id });
            return result;
        }

        public async Task<UserEntity?> GetUserByEmail(string email)
        {
            var result = await _userRepository.GetSingleUserFiltered(new UserFilterRequestDTO() { Email = email });
            return result;
        }

        public async Task<UserEntity> RegisterUser(RegisterUserRequest request)
        {
            var user = await _userRepository.GetSingleUserFiltered(new UserFilterRequestDTO { Email = request.Email });
            if (user != null) throw new UserAlreadyExsistsException(string.Format("User with email {0} already exists", request.Email));

            var strategy = _userRepository.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                IDbContextTransaction? transaction = null;
                try
                {
                    transaction = await _userRepository.Transaction();
                    var createdUser = await _userRepository.CreateUser(new CreateUserRequestDTO { Email = request.Email, FirstName = request.FirstName, LastName = request.LastName, Active = request.Active });
                    await _authenticationServiceLibrary.CreateCredentials(createdUser.Id, request.Password);
                    await transaction.CommitAsync();
                    return createdUser;
                }
                catch (Exception)
                {
                    if (transaction != null)
                        await transaction.RollbackAsync();
                    throw;
                }

            });
        }
    }
}