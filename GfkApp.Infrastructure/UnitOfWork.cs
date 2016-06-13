using GfkApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        private IDbContext _dbContext;

        public void RegisterNew<TEntity>(TEntity entity) where TEntity : class
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public void RegisterDirty<TEntity>(TEntity entity) where TEntity : class
        {
            _dbContext.Entry<TEntity>(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void RegisterClean<TEntity>(TEntity entity) where TEntity : class
        {
            _dbContext.Entry<TEntity>(entity).State = System.Data.Entity.EntityState.Unchanged;
        }

        public void RegisterDeleted<TEntity>(TEntity entity) where TEntity : class
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public async Task<bool> CommitAsync()
        {
            var result = await _dbContext.SaveChangesAsync();
            return result > 0;
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
