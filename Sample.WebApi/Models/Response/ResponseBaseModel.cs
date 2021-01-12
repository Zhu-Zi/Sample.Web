using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.WebApi.Models.Response
{
    public class ResponseBaseModel
    {
        /// <summary>
        /// API接口 返回结果头部
        /// </summary>
        public Head Head { get; set; } = new Head();
    }
}
