using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sample.WebApi.Enums;
using Sample.WebApi.Models.Response;

namespace Sample.WebApi.Helper
{
    public class WebApiResponseHelper
    {
        public static ResponseModel<T> Success<T>(string msg, T data = default(T))
        {
            return Result<T>(HttpStatus.OK, msg, data);
        }

        public static ResponseModel<T> Failure<T>(string msg, T data = default(T))
        {
            return Result<T>(HttpStatus.InternalServerError, msg, data);
        }

        public static ResponseModel<T> Result<T>(HttpStatus code, string msg, T data = default(T))
        {
            return new ResponseModel<T>()
            {
                //Head = { Code = ((int)code).ToString(), CallTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Message = msg },
                Head = { Code = ((int)code).ToString(), CallTime = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"), Message = msg },
                Result = data
            };
        }
    }
}
