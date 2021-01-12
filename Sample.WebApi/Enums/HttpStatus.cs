using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.WebApi.Enums
{
    public enum HttpStatus
    {
        /// <summary>
        /// 成功
        /// </summary>
        OK = 200,

        /// <summary>
        /// 无权限访问
        /// </summary>
        Unauthorized = 401,

        /// <summary>
        /// 地址不存在
        /// </summary>
        NotFound = 404,

        /// <summary>
        /// 操作失败
        /// </summary>
        InternalServerError = 500,
    }
}
