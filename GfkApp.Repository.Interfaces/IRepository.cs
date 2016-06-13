using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GfkApp.Domain;

namespace GfkApp.Repository.Interfaces
{
    public interface IRepository<TAggregateRoot> where TAggregateRoot : class, IAggregateRoot
    {

        IQueryable<TAggregateRoot> Get(string id);

        IQueryable<TAggregateRoot> GetAll();
    }
}
