using Portfolio_API.Data;

namespace Portfolio_API.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;




        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
