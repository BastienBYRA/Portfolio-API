using Portfolio_API.Data;

namespace Portfolio_API.Services.Langage
{
    public class LangageRepository : GenericRepository<Portfolio_API.Models.Langage>
    {
        public LangageRepository(AppDbContext context) : base(context)
        {
        }
    }
}
