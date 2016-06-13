using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Infrastructure
{
    public class Result
    {
        public Result()
        {
            this.Sucess = true;
        }

        public bool Sucess { get; set; }
        public string Message { get; set; }
    }
}
