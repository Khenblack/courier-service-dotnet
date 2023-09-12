using CourierServiceDotnet.DBContext;
using CourierServiceDotnet.Services.Courier.Domain.Entities;
using CourierServiceDotnet.Services.Courier.Domain.InfrastructureContracts;
using CourierServiceDotnet.Services.Courier.Infrastructure.Entities;
using CourierServiceDotnet.Services.Courier.Infrastructure.Mappers;

namespace CourierServiceDotnet.Services.Courier.Infrastructure
{
    public class CourierRepository : RepositoryBase<CourierDB>, IRepository<CourierDB>, ICourierRepository
    {
        public CourierRepository(DataBaseContext dbContext) : base(dbContext)
        {
        }

        public async Task<CourierEntity> CreateCourier(string name, int capacity)
        {
            var result = new CourierDB(0, capacity, name);
            await Add(result);
            await SaveChanges();
            var resultMapped = EntityMapper.Map(result);
            return resultMapped;
        }

        public async Task<List<CourierEntity>> GetCouriers()
        {
            var result = await GetAll();
            var resultMapped = EntityMapper.Map(result);
            return resultMapped;
        }
    }

}