using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Domain.Entity
{
    [Table("AspNetRefreshToken")]
    public class RefreshToken : IAggregateRoot
    {
        [Key]
        public string Id { get; set; }

        public string UserName { get; set; }

        public Guid ClientId { get; set; }

        public DateTime IssuedUtc { get; set; }

        public DateTime ExpiresUtc { get; set; }

        public string ProtectedTicket { get; set; }
    }
}
