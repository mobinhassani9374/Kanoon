using Kanoon.Data.Context;
using Kanoon.DomainModels.Entities;
using Kanoon.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kanoon.Data
{
    public class BaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public ServiceResult Create(TEntity entity)
        {
            _context.Add(entity);
            return _context.Save();
        }

        public ServiceResult Create<T>(T entity) where T : BaseEntity
        {
            _context.Add(entity);
            return _context.Save();
        }

        public IQueryable<TEntity> AsQueryable()
        {
            return _context.Set<TEntity>().AsQueryable();
        }
        public IQueryable<T> AsQueryable<T>() where T : BaseEntity
        {
            return _context.Set<T>().AsQueryable();
        }

        public TEntity Find(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public ServiceResult Update(TEntity entity)
        {
            _context.Update(entity);
            return _context.Save();
        }

        public ServiceResult Delete(TEntity entity)
        {
            _context.Remove(entity);
            return _context.Save();
        }

        public ServiceResult Delete<T>(T entity) where T : BaseEntity
        {
            _context.Remove(entity);
            return _context.Save();
        }

        public ServiceResult DeleteAll<T>(List<T> entities) where T : BaseEntity
        {
            entities.ForEach(c =>
            {
                _context.Remove(c);
            });

            return _context.Save();
        }
    }
}
