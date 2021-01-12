using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.WebApi.Models.Response
{
    public class Head
    {
        public string Message { get; set; }
        public string Code { get; set; }
        public string CallTime { get; set; }
    }
}
