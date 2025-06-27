﻿using System.Collections.Generic;

namespace PortalCOSIE.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
