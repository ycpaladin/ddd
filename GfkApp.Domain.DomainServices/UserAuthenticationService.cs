using GfkApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GfkApp.Domain.Entity;

namespace GfkApp.Domain.DomainServices
{
    public class UserAuthenticationService : IUserAuthenticationService
    {
        private IUserRepository _userRespository;
        public UserAuthenticationService(IUserRepository userRespository)
        {
            this._userRespository = userRespository;
        }

        public async Task<string> Verfiy(Entity.User user)
        {
            return await Task.Run(() =>
            {
                return "";
            });
        }


        public async Task<User> Validate(string loginName, string password)
        {
            var result = await this._userRespository.GetAll().FirstOrDefaultAsync(t => t.LoginName == loginName && t.Password == password);
            return result;
        }
    }
}
