using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GfkApp.Web.Models
{
    [Table("AspNetRefreshToken")]
    public class RefreshToken
    {
        [Key]
        public string Id { get; set; }

        public string Subject { get; set; }

        public DateTime IssuedUtc { get; set; }

        public DateTime ExpiresUtc { get; set; }

        public string ProtectedTicket { get; set; }

    }
}