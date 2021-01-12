using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sample.WebApi.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace Sample.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// 获取Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<string> GetId(int id)
        {
            return await Task.Run(() => { return id.ToString(); });
        }

        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSum")]
        public async Task<int> GetSum(int num1, int num2)
        {
            return await Task.Run(() => { return (num1 + num2); });
        }

        /// <summary>
        /// post 获取 Id
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PostInfo")]
        public async Task<string> PostInfo([FromBody]InfoParam param)
        {
            return await Task.Run(() => { return param.Id.ToString(); });
        }
    }
}
