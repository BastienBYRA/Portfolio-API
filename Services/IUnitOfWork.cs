namespace Portfolio_API.Services
{
    public interface IUnitOfWork : IDisposable
    {
        #region Repository

        #endregion

        int Save();
    }
}
