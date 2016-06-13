using GfkApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Repository.Interfaces
{
    public interface IRefreshTokenRepository: IRepository<RefreshToken>
    {
        Task<bool> Insert(RefreshToken entity);

        Task<bool> Remove(string id);
     }
}
