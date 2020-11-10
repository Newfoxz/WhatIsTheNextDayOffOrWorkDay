using System;
using System.Collections.Generic;
using System.Text;

namespace WhatIsTheNextDayOffOrWorkDay.Domain.Contract
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Add(T entity);
        T GetById(int id);
        T GetByFilter(Predicate<T> entity);
        ICollection<T> GetAll();
        ICollection<T> GetManyByFilter(Predicate<T> entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
