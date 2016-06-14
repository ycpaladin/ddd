using GfkApp.Domain.Entity;
using GfkApp.Infrastructure.Interfaces;
using GfkApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GfkApp.Infrastructure;

namespace GfkApp.Repository
{
    public class RefreshTokenRepository : BaseRepository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(IDbContext dbContext)
            : base(dbContext)
        {

        }

        //public async Task<bool> Insert(RefreshToken entity)
        //{
        //    var unitOfWork = new UnitOfWork(this.DbContext);
        //    unitOfWork.RegisterNew(entity);
        //    return await unitOfWork.CommitAsync();
        //}

        //public async Task<bool> Remove(string id)
        //{
        //    var unitOfWork = new UnitOfWork(this.DbContext);
        //    var entity = this.Get(id);
        //    unitOfWork.RegisterDeleted(entity);
        //    return await unitOfWork.CommitAsync();
        //}

        //public async Task<User> GetUser(string loginName, string password)
        //{
        //    return await this.GetAll().FirstOrDefaultAsync(t => t.LoginName == loginName && t.Password == password);
        //}
    }
}
