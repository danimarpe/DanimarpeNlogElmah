using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanimarpeNlogElmah.Logger
{
    /// <summary>
    /// Factory pattern, just creates loggers based on its names
    /// </summary>
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            throw new ArgumentException();
        }

        /// <summary>
        /// Creates a logger from its name
        /// </summary>
        /// <param name="loggerName"></param>
        /// <returns></returns>
        public ILogger CreateLogger(string loggerName)
        {
            switch (loggerName)
            {
                case LoggerKeys.Elmah:
                    return new ElmahLogger();
                default:
                    throw new ArgumentException();
            }
        }
    }

}
