﻿using System.Linq;
using Food.EntityFramework.Entities;

namespace Food.EntityFramework
{
    internal interface IRepository<TEntity> where TEntity : IEntity
    {
        IQueryable<TEntity> All { get; }
        TEntity GetItem(int id);
        TEntity Save(TEntity item);
        void Delete(TEntity item);
        void Delete(int id);
    }
}
