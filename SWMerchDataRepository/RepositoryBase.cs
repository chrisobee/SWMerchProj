using Microsoft.EntityFrameworkCore;
using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SWMerchDataRepository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext ApplicationDbContext { get; set; }
        public RepositoryBase(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }
        public void Create(T entity)
        {
            ApplicationDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            ApplicationDbContext.Set<T>().Remove(entity);
        }

        public async Task<IQueryable<T>> FindAll()
        {
            return ApplicationDbContext.Set<T>();
        }

        public async Task<IQueryable<T>> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return ApplicationDbContext.Set<T>().Where(expression);
        }

        public void Update(T entity)
        {
            ApplicationDbContext.Set<T>().Update(entity);
        }
    }
}
