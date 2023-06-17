using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Portfolio_API.Services
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Récupère tout les éléments de la base de données pour une classe donnée.
        /// </summary>
        /// <returns>Retourne une List de la classe donnée.</returns>
        Task<List<TEntity>> GetAll(int? page, int? numberPerPage);

        /// <summary>
        /// Récupère un élément de la base de données pour une classe donnée.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retourne un objet de la classe donnée.</returns>
        ValueTask<TEntity> GetById(object id);

        /// <summary>
        /// Ajoute un élément dans la liste des éléments à enregistrer dans la base de données
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);

        /// <summary>
        /// Ajoute un élément de manière <u>asynchrone</u> dans la liste des éléments à enregistrer dans la base de données
        /// </summary>
        /// <param name="entity"></param>
        void AddAsync(TEntity entity);

        /// <summary>
        /// Ajoute une liste d'éléments dans la liste des éléments à enregistrer dans la base de données
        /// </summary>
        /// <param name="entity"></param>
        void AddRange(IEnumerable<TEntity> entities);

        /// <summary>
        /// Ajoute une liste d'éléments de manière <u>asynchrone</u> dans la liste des éléments à enregistrer dans la base de données
        /// </summary>
        /// <param name="entity"></param>
        void AddRangeAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// Ajoute un élément dans la liste des éléments à supprimer dans la base de données
        /// </summary>
        /// <param name="entity"></param>
        void Remove(TEntity entity);

        /// <summary>
        /// Ajoute une liste d'éléments dans la liste des éléments à supprimer dans la base de données
        /// </summary>
        /// <param name="entity"></param>
        void RemoveRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void UpdateRange(IEnumerable<TEntity> entities);

        void Entry_Modified(TEntity entity);
    }
}
