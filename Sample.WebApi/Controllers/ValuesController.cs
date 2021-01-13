using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sample.WebApi.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Sample.WebApi.Context;
using Sample.WebApi.Entities;

namespace Sample.WebApi.Controllers
{
    public class ValuesController : BaseController
    {
        private readonly ApplicationDbContext _context;

        public ValuesController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSum")]
        public async Task<IActionResult> GetSum(int num1, int num2)
        {
            return await Task.Run(() =>
            {
                return Ok(Success((num1 + num2).ToString(), DateTime.UtcNow));
            });
        }

        /// <summary>
        /// post 插入数据 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("InsertInfo")]
        public async Task<IActionResult> InsertInfo([FromBody]InfoParam param)
        {
            return await Task.Run(() =>
            {
                var info = new InfoTest
                {
                    Name = param.Name,
                    Remark = param.Remark
                };

                return SaveData(info);
            });
        }

        #region private function

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="info">数据</param>
        /// <returns></returns>
        private IActionResult SaveData(InfoTest info)
        {
            try
            {
                _context.InfoTest.Add(info);
                var num = _context.SaveChanges().ToString();

                return Ok(Success($"Lines:{num}", $"UtcDatetime:{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}"));
            }
            catch
            {
                return BadRequest(Failure("Failure", $"UtcDatetime:{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}"));
            }
        }

        #endregion
    }
}
