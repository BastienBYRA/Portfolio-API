using Portfolio_API.Services.Experience;
using Portfolio_API.Services.Langage;
using System;
using System.Threading.Tasks;

namespace Portfolio_API.Services
{
    public interface IUnitOfWork : IDisposable
    {
        #region Liste des Repositories
        public ExperienceRepository ExperienceRepository { get; set; }
        public LangageRepository LangageRepository { get; set; }
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


        //Mettre en place les transaction : https://dotnettutorials.net/lesson/unit-of-work-csharp-mvc/
/*        //Start the database Transaction
        void CreateTransaction();
        //Commit the database Transaction
        void Commit();
        //Rollback the database Transaction
        void Rollback();*/
    }
}
