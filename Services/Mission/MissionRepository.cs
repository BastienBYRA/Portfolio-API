using Portfolio_API.Data;

namespace Portfolio_API.Services.Mission
{
    public class MissionRepository : GenericRepository<Portfolio_API.Models.Mission>
    {
        public MissionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
