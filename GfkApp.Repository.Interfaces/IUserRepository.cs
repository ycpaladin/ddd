using GfkApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {

        Task<User> GetUser(string loginName, string password);

    }
}
