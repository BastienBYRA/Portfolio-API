using Portfolio_API.Data;
using Portfolio_API.Services.Experience;
using Portfolio_API.Services.Langage;

namespace Portfolio_API.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        #region Liste des Repositories
        public ExperienceRepository ExperienceRepository { get; set; }
        public LangageRepository LangageRepository { get; set; }
        #endregion

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            ExperienceRepository = new ExperienceRepository(context);
            LangageRepository = new LangageRepository(context);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
