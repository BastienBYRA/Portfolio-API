using Portfolio_API.Data;
using Portfolio_API.Models;

namespace Portfolio_API.Services.Experience
{
    public class ExperienceRepository : GenericRepository<Portfolio_API.Models.Experience>
    {
        public ExperienceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
