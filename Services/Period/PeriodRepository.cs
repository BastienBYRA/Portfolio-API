using Portfolio_API.Data;

namespace Portfolio_API.Services.Period
{
    public class PeriodRepository : GenericRepository<Portfolio_API.Models.Period>
    {
        public PeriodRepository(AppDbContext context) : base(context)
        {
        }
    }
}
