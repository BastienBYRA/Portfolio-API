using Portfolio_API.Data;

namespace Portfolio_API.Services.Type_Experience
{
    public class Type_ExperienceRepository : GenericRepository<Portfolio_API.Models.Type_Experience>
    {
        public Type_ExperienceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
