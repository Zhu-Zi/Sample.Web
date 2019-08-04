using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Xunit;
using Sample.WebApi.Models.Request;

namespace Sample.WebApi.xUnit
{
    public class ValuesTests
    {
        public ValuesTests()
        {
            var server = new TestServer(WebHost.CreateDefaultBuilder()
                .UseStartup<Sample.WebApi.Startup>());
            Client = server.CreateClient();
        }

        public HttpClient Client { get; }

        /// <summary>
        /// ���������ʹ�� Theory ����
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Theory(DisplayName = "��ȡId����")]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("2")]
        public async Task GetId_ShouldBe_Ok(string id)
        {
            var response = await Client.GetAsync($"/api/values/{id}");
            var responseText = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(id.ToString(), responseText);
        }

        /// <summary>
        /// �޲�������ʹ�� Fact ����
        /// </summary>
        /// <returns></returns>
        [Fact(DisplayName = "Post ��������")]
        public async Task PostInfo_ShouldBe_Ok()
        {
            var param = new InfoParam()
            {
                Id = "123",
                Remark = "Test"
            };

            var httpContent = new StringContent(JsonConvert.SerializeObject(param));
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await Client.PostAsync("/api/values/PostInfo", httpContent);
            var responseText = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(param.Id, responseText);
        }

        /// <summary>
        /// �����ò�������
        /// </summary>
        [Fact(Skip = "�ع�δ���")]
        public async Task Test()
        {
            var expected = string.Empty;
            var actual = string.Empty;

            Assert.Equal(expected, actual);
        }
    }
}
