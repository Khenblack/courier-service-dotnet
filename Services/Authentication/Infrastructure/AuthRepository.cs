using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourierServiceDotnet.DBContext;
using CourierServiceDotnet.Services.Authentication.Domain.Entities;
using CourierServiceDotnet.Services.Authentication.Domain.InfrastructureContracts;
using CourierServiceDotnet.Services.Authentication.Infrastructure.DBEntities;
using CourierServiceDotnet.Services.Authentication.Infrastructure.Mappers;
using Microsoft.EntityFrameworkCore;

namespace CourierServiceDotnet.Services.Authentication.Infrastructure
{
    public class AuthRepository : RepositoryBase<AuthDB>, IRepository<AuthDB>, IAuthRepository
    {
        public AuthRepository(DataBaseContext dbContext) : base(dbContext)
        {
        }

        public async Task<Auth> CreateAuth(int userId, byte[] passwordHash, byte[] passwordSalt)
        {
            var res = new AuthDB(userId, passwordHash, passwordSalt);
            await Add(res);
            await SaveChanges();
            var resultMapped = EntityMapper.Map(res);
            return resultMapped;
        }

        public async Task<Auth?> GetAuthByUser(int userId)
        {
            var result = await Query().Where(x => x.UserId == userId).FirstOrDefaultAsync();
            if (result == null) return null;
            var resultMapped = EntityMapper.Map(result);
            return resultMapped;
        }
    }
}