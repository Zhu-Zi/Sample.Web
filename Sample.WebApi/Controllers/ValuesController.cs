using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.WebApi.Models.Request;

namespace Sample.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<string> GetId(int id)
        {
            return await Task.Run(() => { return id.ToString(); });
        }

        [HttpGet]
        [Route("GetSum")]
        public async Task<int> GetSum(int num1, int num2)
        {
            return await Task.Run(() => { return (num1 + num2); });
        }

        [HttpPost]
        [Route("PostInfo")]
        public async Task<string> PostInfo([FromBody]InfoParam param)
        {
            return await Task.Run(() => { return param.Id.ToString(); });
        }
    }
}
