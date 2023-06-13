using System;
using System.Threading.Tasks;

namespace Portfolio_API.Services
{
    public interface IUnitOfWork : IDisposable
    {
        #region Liste des Repositories

        #endregion

        /// <summary>
        /// Sauvegarde les données en base
        /// </summary>
        /// <returns>Retourne le nombre d'objet ayant subi une modification dans la base</returns>
        int Save();

        /// <summary>
        /// Sauvegarde les données en base, de manière asynchrone
        /// </summary>
        /// <returns>Retourne le nombre d'objet ayant subi une modification dans la base</returns>
        Task<int> SaveAsync();
    }
}
