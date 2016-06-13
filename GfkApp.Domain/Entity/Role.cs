using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Domain.Entity
{
    public class Role : IAggregateRoot
    {
        public Role()
        {
            this.UserRoleRef = new List<UserRoleRef>();
        }

        public string Id { get; set; }

        public string RoleName { get; set; }

        public ICollection<UserRoleRef> UserRoleRef { get; set; }
    }
}
