﻿using System.Linq;

namespace UtilityBilling.Data
{
    public interface IDataRepository<T>
    {
        IQueryable<T> FindAll();

        T Get(object id);

        void Insert(T entity);

        void Delete(T entity);
    }
}