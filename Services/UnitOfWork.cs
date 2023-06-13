using Portfolio_API.Data;

namespace Portfolio_API.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        #region Liste des Repositories
        /**public IResultRepository ResultRepository { get; private set; }**/
        #endregion

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            /**ResultRepository = new ResultRepository.ResultRepository(_context);**/
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
