using System;
using System.Collections.Generic;
using System.Text;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;

namespace WhatIsTheNextDayOffOrWorkDay.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetByFilter(Predicate<T> entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetManyByFilter(Predicate<T> entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
