using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;
using WhatIsTheNextDayOffOrWorkDay.Repository.Context;

namespace WhatIsTheNextDayOffOrWorkDay.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly WhatIsTheNextDayOffOrWorkDayDbContext WhatIsTheNextDayOffOrWorkDayDbContext;

        public Repository(WhatIsTheNextDayOffOrWorkDayDbContext whatIsTheNextDayOffOrWorkDayDbContext)
        {
            WhatIsTheNextDayOffOrWorkDayDbContext = whatIsTheNextDayOffOrWorkDayDbContext;
        }

        public void Add(T entity)
        {
            WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().Add(entity);
            WhatIsTheNextDayOffOrWorkDayDbContext.SaveChanges();
        }

        public void Dispose()
        {
            WhatIsTheNextDayOffOrWorkDayDbContext.Dispose();
        }

        public ICollection<T> GetAll()
        {
            return WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().ToList();
        }

        public T GetByFilter(Predicate<T> match)
        {
            return WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().ToList().Find(match);
        }

        public T GetById(int id)
        {
            return WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().Find(id);
        }

        public ICollection<T> GetManyByFilter(Predicate<T> match)
        {
            return WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().ToList().FindAll(match);
        }

        public void Remove(T entity)
        {
            WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().Remove(entity);
            WhatIsTheNextDayOffOrWorkDayDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().Update(entity);
            WhatIsTheNextDayOffOrWorkDayDbContext.SaveChanges();
        }
    }
}
