﻿using Portfolio_API.Data;
using Portfolio_API.Models;
using Portfolio_API.Services.Experience;
using Portfolio_API.Services.Langage;
using Portfolio_API.Services.Category_Language;
using Portfolio_API.Services.Mission;
using Portfolio_API.Services.Period;
using Portfolio_API.Services.Project;
using Portfolio_API.Services.Type_Experience;

namespace Portfolio_API.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        #region Liste des Repositories
        public ExperienceRepository ExperienceRepository { get; set; }
        public LangageRepository LangageRepository { get; set; }
        public Category_LanguageRepository Category_LanguageRepository { get; set; }
        public MissionRepository MissionRepository { get; set; }
        public PeriodRepository PeriodRepository { get; set; }
        public ProjectRepository ProjectRepository { get; set; }
        public Type_ExperienceRepository Type_ExperienceRepository { get; set; }
        #endregion

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            ExperienceRepository = new ExperienceRepository(context);
            LangageRepository = new LangageRepository(context);
            Category_LanguageRepository = new Category_LanguageRepository(context);
            MissionRepository = new MissionRepository(context);
            PeriodRepository = new PeriodRepository(context);
            ProjectRepository = new ProjectRepository(context);
            Type_ExperienceRepository = new Type_ExperienceRepository(context);
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
