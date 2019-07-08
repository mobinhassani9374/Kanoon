﻿using AutoMapper;
using Kanoon.Data.Context;
using Kanoon.DomainModels.Entities;
using Kanoon.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.Data.Repositories
{
    public abstract class BaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly AppDbContext _context;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
        public ServiceResult<int> Create<TModel>(TModel model)
        {
            var entity = Mapper.Map<TEntity>(model);
            if (_context.Save() == ServiceResult.Okay())
            {
                return ServiceResult<int>.Okay(entity.Id);
            }
            return ServiceResult<int>.Error(-1);
        }

        public ServiceResult Update<TModel>(int id, TModel model)
        {
            var oldEntity = Find(id);
            if (oldEntity == null) return ServiceResult.Error("شناسه ارسال شده نامعتبر است");
            var entity = Mapper.Map(model, oldEntity);
            _context.Update(entity);
            return _context.Save();
        }

        public ServiceResult Delete(int id)
        {
            var entity = Find(id);
            if (entity == null) return ServiceResult.Error("شناسه ارسال شده نامعتبر است");
            _context.Remove(entity);
            return _context.Save();
        }

        public ServiceResult Delete(TEntity entity)
        {
            _context.Remove(entity);
            return _context.Save();
        }
        public TEntity Find(int id)
        {
            return _context.Set<TEntity>().Find(id); ;
        }
    }
}
