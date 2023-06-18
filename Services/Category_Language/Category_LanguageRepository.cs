using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Portfolio_API.Data;
using Microsoft.EntityFrameworkCore;

namespace Portfolio_API.Services.Category_Language
{
    public class Category_LanguageRepository : GenericRepository<Portfolio_API.Models.Category_Language>
    {
/*        protected readonly AppDbContext context;*/

        public Category_LanguageRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<List<Models.Category_Language>> GetAll(int? page, int? numberPerPage)
        {
            int numberPage = (page ?? 1);
            int numberShowPerPage = (numberPerPage ?? 5);

            try
            {
                return await _context.Category_Languages.Include(x => x.Langages).Skip((numberPage - 1) * numberShowPerPage).Take(numberShowPerPage).ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override async Task<Models.Category_Language> GetById(object id)
        {
            return await _context.Category_Languages.Include(x => x.Langages).Where(x => x.Id == (int)id).FirstOrDefaultAsync();
        }
    }
}
