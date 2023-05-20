using DemoParking.EntityFramework;

namespace DemoParking.Services
{
    public class InOutService
    {
        private readonly AppDbContext _dbContext;
        public InOutService(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
    }
}
