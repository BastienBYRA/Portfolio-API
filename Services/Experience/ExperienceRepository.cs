using Microsoft.EntityFrameworkCore;
using Portfolio_API.Data;
using Portfolio_API.Models;

namespace Portfolio_API.Services.Experience
{
    public class ExperienceRepository : GenericRepository<Portfolio_API.Models.Experience>
    {
        public ExperienceRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<List<Models.Experience>> GetAll(int? page, int? numberPerPage)
        {
            int numberPage = (page ?? 1);
            int numberShowPerPage = (numberPerPage ?? 5);

            try
            {
                return await _context.Experiences
                    .Include(x => x.Missions)
                    .Include(x => x.Period)
                    .Include(x => x.Type_Experience)
                    .Skip((numberPage - 1) * numberShowPerPage).Take(numberShowPerPage)
                    .ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override async Task<Models.Experience> GetById(object id)
        {
            return await _context.Experiences.Include(x => x.Missions).Include(x => x.Period).Include(x => x.Type_Experience).Where(x => x.Id == (int)id).FirstOrDefaultAsync();
        }
    }
}
