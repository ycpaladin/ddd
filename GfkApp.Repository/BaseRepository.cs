using GfkApp.Domain;
using GfkApp.Infrastructure.Interfaces;
using GfkApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GfkApp.Repository
{
    public abstract class BaseRepository<TAggregateRoot> : IRepository<TAggregateRoot> where TAggregateRoot : class, IAggregateRoot
    {

        private readonly IQueryable<TAggregateRoot> _entities;

        protected IDbContext DbContext { get; private set; }

        public BaseRepository(IDbContext dbContext)
        {
            this.DbContext = dbContext;
            this._entities = dbContext.Set<TAggregateRoot>();

        }

        public IQueryable<TAggregateRoot> Get(string id)
        {
            return this._entities.Where(t => t.Id == id);
        }

        public IQueryable<TAggregateRoot> GetAll()
        {
            return this._entities;
        }

        public async Task<TAggregateRoot> FindByIdAsync(string id)
        {
            return await this.Get(id).FirstOrDefaultAsync();
        }
    }
}
