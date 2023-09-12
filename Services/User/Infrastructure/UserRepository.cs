using CourierServiceDotnet.DBContext;
using CourierServiceDotnet.Services.User.Infrastructure.Mappers;
using CourierServiceDotnet.Services.User.Domain.Entities;
using CourierServiceDotnet.Services.User.Domain.InfrastructureContracts;
using CourierServiceDotnet.Services.User.Infrastructure.DBEntities;
using Microsoft.EntityFrameworkCore;
using CourierServiceDotnet.Services.User.Infrastructure.DTO;
using CourierServiceDotnet.Services.User.Domain.InfrastructureContracts.DTO;
using Microsoft.EntityFrameworkCore.Storage;

namespace CourierServiceDotnet.Services.User.Infrastructure
{
    public class UserRepository : RepositoryBase<UserDB>, IRepository<UserDB>, IUserRepository
    {
        public UserRepository(DataBaseContext dbContext) : base(dbContext)
        {
        }

        public async Task<UserEntity?> GetSingleUserFiltered(UserFilterRequestDTO request)
        {
            var query = Query();
            if (request.Id != null)
                query = query.Where(x => x.Id == request.Id);
            if (request.Email != null && !string.IsNullOrEmpty(request.Email))
                query = query.Where(x => x.Email == request.Email);

            var result = await query.FirstOrDefaultAsync();
            if (result == null) return null;
            var resultMapped = EntityMapper.Map(result);
            return resultMapped;
        }

        public async Task<UserEntity> CreateUser(CreateUserRequestDTO request)
        {
            var result = new UserDB(0, request.FirstName, request.LastName, request.Email, request.Active);
            var createdUser = await Add(result);
            await SaveChanges();
            return EntityMapper.Map(createdUser);
        }
    }
}