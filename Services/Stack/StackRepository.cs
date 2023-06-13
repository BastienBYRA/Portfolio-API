using Portfolio_API.Data;

namespace Portfolio_API.Services.Stack
{
    public class StackRepository : GenericRepository<Portfolio_API.Models.Stack>
    {
        public StackRepository(AppDbContext context) : base(context)
        {
        }
    }
}
