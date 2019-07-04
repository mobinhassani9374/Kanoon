﻿using Kanoon.Data.Context;
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

        public IQueryable<TEntity> AsQueryable()
        {
            return _context.Set<TEntity>().AsQueryable();
        }
    }
}
