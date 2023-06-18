using Microsoft.EntityFrameworkCore;
using Portfolio_API.Data;

namespace Portfolio_API.Services.Period
{
    public class PeriodRepository : GenericRepository<Portfolio_API.Models.Period>
    {
        public PeriodRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<List<Models.Period>> GetAll(int? page, int? numberPerPage)
        {
            int numberPage = (page ?? 1);
            int numberShowPerPage = (numberPerPage ?? 5);

            try
            {
                return await _context.Periods
                    .Include(p => p.Experiences)
                        .ThenInclude(e => e.Missions)
                    .Include(p => p.Experiences)
                        .ThenInclude(e => e.Type_Experience)
                    .Skip((numberPage - 1) * numberShowPerPage).Take(numberShowPerPage)
                    .Select(p => new Models.Period
                    {
                        Id = p.Id,
                        YearsStart = p.YearsStart,
                        YearsEnd = p.YearsEnd,
                        Experiences = p.Experiences.Select(e => new Models.Experience
                        {
                            Id = e.Id,
                            Title = e.Title,
                            Content = e.Content,
                            Img_Location = e.Img_Location,
                            Missions = e.Missions,
                            Type_Experience = e.Type_Experience
                        }).ToList()
                    })
                    .ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override async Task<Models.Period?> GetById(object id)
        {
            return await _context.Periods
                .Include(p => p.Experiences)
                    .ThenInclude(e => e.Missions)
                .Include(p => p.Experiences)
                    .ThenInclude(e => e.Type_Experience)
                .Where(p => p.Id == (int)id)
                .Select(p => new Models.Period
                {
                    Id = p.Id,
                    YearsStart = p.YearsStart,
                    YearsEnd = p.YearsEnd,
                    Experiences = p.Experiences.Select(e => new Models.Experience
                    {
                        Id = e.Id,
                        Title = e.Title,
                        Content = e.Content,
                        Img_Location = e.Img_Location,
                        Missions = e.Missions,
                        Type_Experience = e.Type_Experience
                    }).ToList()
                })
                .FirstOrDefaultAsync();
        }
    }
}
