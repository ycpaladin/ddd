using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Application.DTOs
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public bool IsSuper { get; set; }
        public string Postcode { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
