using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.WebApi.Helper;
using Sample.WebApi.Models.Response;

namespace Sample.WebApi.Controllers
{
    /// <summary>
    /// Api 控制器基类
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        #region API 返回方法统一封装

        protected ResponseModel<T> Success<T>(string msg = "Success", T data = default(T))
        {
            return WebApiResponseHelper.Success(msg, data);
        }

        protected ResponseModel<T> Failure<T>(string msg = "Failure", T data = default(T))
        {
            return WebApiResponseHelper.Failure(msg, data);
        }

        protected ResponseBaseModel Success(string msg = "Success", dynamic data = null)
        {
            return WebApiResponseHelper.Success(msg, data);
        }

        protected ResponseBaseModel Failure(string msg = "Failure", dynamic data = null)
        {
            return WebApiResponseHelper.Failure(msg, data);
        }

        #endregion
    }
}
