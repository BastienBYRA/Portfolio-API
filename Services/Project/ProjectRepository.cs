using Microsoft.EntityFrameworkCore;
using Portfolio_API.Data;

namespace Portfolio_API.Services.Project
{
    public class ProjectRepository : GenericRepository<Portfolio_API.Models.Project>
    {
        public ProjectRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<List<Models.Project>> GetAll(int? page, int? numberPerPage)
        {
            int numberPage = (page ?? 1);
            int numberShowPerPage = (numberPerPage ?? 5);

            try
            {
                return await _context.Projects
                    .Include(x => x.Missions)
                    .Include(x => x.Langages)
                    .Select(p => new Models.Project
                    {
                        Id = p.Id,
                        Title = p.Title,
                        ImgLink = p.ImgLink,
                        Job = p.Job,
                        ShortDesc = p.ShortDesc,
                        LongDesc = p.LongDesc,
                        Missions = p.Missions.Select(m => new Models.Mission
                        {
                            Id = m.Id,
                            Title = m.Title,
                        }).ToList(),
                        Langages = p.Langages.Select(l => new Models.Langage
                        {
                            Id = l.Id,
                            Title = l.Title,
                            Background = l.Background,
                            ImgLink = l.ImgLink,
                        }).ToList()
                    })
                    .Skip((numberPage - 1) * numberShowPerPage).Take(numberShowPerPage)
                    .ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override async Task<Models.Project> GetById(object id)
        {
            return await _context.Projects
                .Include(x => x.Missions)
                .Include(x => x.Langages)
                .Select(p => new Models.Project
                {
                    Id = p.Id,
                    Title = p.Title,
                    ImgLink = p.ImgLink,
                    Job = p.Job,
                    ShortDesc = p.ShortDesc,
                    LongDesc = p.LongDesc,
                    Missions = p.Missions.Select(m => new Models.Mission
                    {
                        Id = m.Id,
                        Title = m.Title,
                    }).ToList(),
                    Langages = p.Langages.Select(l => new Models.Langage
                    {
                        Id = l.Id,
                        Title = l.Title,
                        Background = l.Background,
                        ImgLink = l.ImgLink,
                    }).ToList()
                })
                .Where(x => x.Id == (int)id)
                .FirstOrDefaultAsync();
        }
    }
}
