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

        public async Task<IEnumerable<CourierEntity>> GetCouriers()
        {
            var result = await GetAll();
            var resultMapped = EntityMapper.Map(result);
            return resultMapped;
        }
    }

}