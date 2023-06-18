using Microsoft.EntityFrameworkCore;
using Portfolio_API.Data;

namespace Portfolio_API.Services.Type_Experience
{
    public class Type_ExperienceRepository : GenericRepository<Portfolio_API.Models.Type_Experience>
    {
        public Type_ExperienceRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<List<Models.Type_Experience>> GetAll(int? page, int? numberPerPage)
        {
            int numberPage = (page ?? 1);
            int numberShowPerPage = (numberPerPage ?? 5);

            try
            {
                return await _context.Types_Experiences
                    .Include(x => x.Experiences)
                    .Skip((numberPage - 1) * numberShowPerPage).Take(numberShowPerPage)
                    .ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override async Task<Models.Type_Experience> GetById(object id)
        {
            return await _context.Types_Experiences
                .Include(x => x.Experiences)
                .Where(x => x.Id == (int)id).FirstOrDefaultAsync();
        }
    }
}
