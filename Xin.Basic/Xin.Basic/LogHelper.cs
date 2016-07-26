using log4net;
using log4net.Appender;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    /// <summary>
    /// log4net日志工具类
    /// </summary>
    public class LogHelper
    {
        /// <summary>
        /// 日志记录器
        /// </summary>
        public static ILog Logger { get; set; }

        static LogHelper()
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));
            Logger = LogManager.GetLogger("Logger");
        }
    }
}
