using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.WebApi.Models.Response
{
    public class ResponseModel<T> : ResponseBaseModel
    {
        /// <summary>
        /// API接口 返回结果
        /// </summary>
        public T Result { get; set; }
    }
}
