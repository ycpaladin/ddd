using GfkApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Domain.DomainServices
{
    public interface IUserAuthenticationService
    {

        Task<string> Verfiy(User user);


        Task<User> Validate(string loginName, string password);
    }
}
