using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Sample.WebApi.AppConfig
{
    public class AppConfig
    {
        private static IConfigurationRoot _config { get; set; }

        static AppConfig()
        {
#if DEBUG
            // 测试用
            var evnName = "DEV";  
#else
            // Microsoft.Extensions.Configuration 扩展包提供的
            var evnName = Environment.GetEnvironmentVariable("INSIGHT_ENV");
#endif
            var builder = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.{evnName}.json", optional: false)
                .AddEnvironmentVariables();
            _config = builder.Build();
        }

        public static IConfigurationRoot AppSettings
        {
            get
            {
                return _config;
            }
        }

        public static string Get(string key)
        {
            return _config[key];
        }

        public static string GetConnectionString(string key)
        {
            return _config.GetConnectionString(key);
        }
    }
}
