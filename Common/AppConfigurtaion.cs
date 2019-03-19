using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

namespace Common
{
    /// <summary>
    /// 配置文件对象属性必须为属性器..
    /// </summary>
    public class FileConfig
    {
        /// <summary>
        /// 文件上传路径
        /// </summary>
        public string FileUpPath { get; set; }
        /// <summary>
        /// 允许上传的文件格式
        /// </summary>
        public string AttachExtension { get; set; }
        /// <summary>
        /// 文件上传最大值KB
        /// </summary>
        public string AttachImagesize { get; set; }
    }
    /// <summary>
    /// 配置文件读取
    /// </summary>
    public class AppConfigurtaion
    {
       /// <summary>
       /// 读取配置文件对象节点
       /// </summary>
       /// <typeparam name="T"></typeparam>
       /// <param name="key"></param>
       /// <returns></returns>
        public static  T GetAppSettings<T>(string key) where T : class, new()
        {
            IConfiguration config = new ConfigurationBuilder()
            .Add(new JsonConfigurationSource { Path = "customsettings.json", ReloadOnChange = true })
            .Build();



            var appconfig = new ServiceCollection()
            .AddOptions()
            .Configure<T>(config.GetSection(key))
            .BuildServiceProvider()
            .GetService<IOptions<T>>()
            .Value;



            return appconfig;
        }
        /// <summary>
        /// 读取配置文件非对象节点
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static dynamic GetAppSettings(string key) 
        {
            IConfiguration config = new ConfigurationBuilder()
            .Add(new JsonConfigurationSource { Path = "customsettings.json", ReloadOnChange = true })
            .Build();
           
            return config.GetSection(key).Value;
        }

    }
}
