using Portfolio_API.Data;

namespace Portfolio_API.Services.Project
{
    public class ProjectRepository : GenericRepository<Portfolio_API.Models.Project>
    {
        public ProjectRepository(AppDbContext context) : base(context)
        {
        }
    }
}
