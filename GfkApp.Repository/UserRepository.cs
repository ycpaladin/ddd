using GfkApp.Domain.Entity;
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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IDbContext dbContext)
            : base(dbContext)
        {

        }

        public async Task<User> GetUser(string loginName, string password)
        {
            return await this.GetAll().FirstOrDefaultAsync(t => t.LoginName == loginName && t.Password == password);
        }
    }
}
