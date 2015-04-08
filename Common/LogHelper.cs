using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Common
{
    public class LogHelper
    {
        /// <summary>
        /// 默认从LogUtinity.config初始化
        /// </summary>
        public LogHelper()
        {
            string str = System.Environment.CurrentDirectory;
            string config = Path.Combine(str, "Common.config");
            FileInfo fi = new FileInfo(config);
            log4net.Config.XmlConfigurator.Configure(fi);
        }
        /// <summary>
        /// 从App.config配置初始化
        /// </summary>
        /// <param name="selfConfig">是否从程序App.config加载配置</param>
        public LogHelper(bool selfConfig)
        {
            if (selfConfig)
            {
                log4net.Config.XmlConfigurator.Configure();
            }
        }
        public  void WriteLog(Type t, Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error("Error", ex);
        }
        public  void WriteLog(Type t, string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Info(msg);
        }
        public  void WriteLog(string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("MyLogger");
            log.Info(msg);
            
        }
    }
}
