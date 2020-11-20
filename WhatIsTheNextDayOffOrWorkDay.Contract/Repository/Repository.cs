using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
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

        public void Create(T entity)
        {
            WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().Add(entity);
            WhatIsTheNextDayOffOrWorkDayDbContext.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().Update(entity);
            WhatIsTheNextDayOffOrWorkDayDbContext.SaveChangesAsync();
        }

        public void Remove(T entity)
        {
            WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().Remove(entity);
            WhatIsTheNextDayOffOrWorkDayDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            WhatIsTheNextDayOffOrWorkDayDbContext.Dispose();
        }

        public async Task<T> GetById(int id)
        {
            return await WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().FindAsync(id);
        }

        public async Task<ICollection<T>> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return await WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().Where(expression).ToListAsync();
        }

        public async Task<ICollection<T>> GetAll()
        {
            return await WhatIsTheNextDayOffOrWorkDayDbContext.Set<T>().ToListAsync();
        }
    }
}
