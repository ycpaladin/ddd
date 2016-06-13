using GfkApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Application.Interfaces
{
    public interface IRefreshTokenService
    {

        Task<RefreshToken> Get(string id);

        Task<bool> Save(RefreshToken entity);

        Task<bool> Remove(string id);
    }
}
