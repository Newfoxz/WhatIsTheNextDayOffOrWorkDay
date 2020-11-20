using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WhatIsTheNextDayOffOrWorkDay.Domain.Contract
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Create(T entity);
        void Update(T entity);
        void Remove(T entity);
        Task<T> GetById(int id);
        Task<ICollection<T>> GetByCondition(Expression<Func<T, bool>> expression);
        Task<ICollection<T>> GetAll();
    }
}
