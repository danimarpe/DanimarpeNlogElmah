using System;

namespace DanimarpeNlogElmah.Logger
{
    /// <summary>
    /// BaseLogger class. Implements the ILogger interface.
    /// It has all the methods to write entries in Nlog
    /// </summary>
    public class BaseLogger : ILogger
    {
        private readonly NLog.Logger logger;

        public BaseLogger(string loggerkey)
        {
            if (loggerkey != null && loggerkey != string.Empty)
                logger = NLog.LogManager.GetLogger(loggerkey);
        }

        /// <summary>
        /// Detailed flow system level. Used to debug the software.
        /// </summary>
        /// <param name="message"></param>
        public virtual void Debug(string message)
        {
            logger.Debug(message);
        }

        /// <summary>
        /// Detailed flow system level. Used to debug the software.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public virtual void Debug(string message, Exception ex)
        {
            logger.Debug(ex, message, null);
        }

        /// <summary>
        /// Detailed flow system level. Used to debug the software.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <param name="parametros"></param>
        public virtual void Debug(string message, Exception ex, object[] parametros)
        {
            logger.Debug(ex, message, parametros);
        }

        /// <summary>
        ///  Visible in state consoles. Used to log "crash" exceptions, but not "lethal" to the software.
        /// </summary>
        /// <param name="message"></param>
        public virtual void Error(string message)
        {
            logger.Error(message);
        }

        /// <summary>
        ///  Visible in state consoles. Used to log "crash" exceptions, but not "lethal" to the software.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public virtual void Error(string message, Exception exception)
        {
            logger.Error(exception, message, null);
        }

        /// <summary>
        ///  Visible in state consoles. Used to log "crash" exceptions, but not "lethal" to the software.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="parametros"></param>
        public virtual void Error(string message, Exception exception, object[] parametros)
        {
            logger.Error(exception, message, parametros);
        }

        /// <summary>
        /// Visible in state consoles. Used to log "crash" exceptions, which are "lethal" to the software.
        /// </summary>
        /// <param name="message"></param>
        public virtual void Fatal(string message)
        {
            logger.Fatal(message);
        }

        /// <summary>
        /// Visible in state consoles. Used to log "crash" exceptions, which are "lethal" to the software.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public virtual void Fatal(string message, Exception exception)
        {
            logger.Fatal(exception, message, null);
        }

        /// <summary>
        /// Visible in state consoles. Used to log "crash" exceptions, which are "lethal" to the software.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="parametros"></param>
        public virtual void Fatal(string message, Exception exception, object[] parametros)
        {
            logger.Fatal(exception, message, parametros);
        }

        /// <summary>
        ///  Visible in state consoles. Used to log general information.
        /// </summary>
        /// <param name="message"></param>
        public virtual void Info(string message)
        {
            logger.Info(message);
        }

        /// <summary>
        /// Detailed level. Just to trace the code.
        /// </summary>
        /// <param name="message"></param>
        public virtual void Trace(string message)
        {
            logger.Trace(message);
        }

        /// <summary>
        /// Used to log non "chrash" errors. Visible in state consoles.
        /// </summary>
        /// <param name="message"></param>
        public virtual void Warn(string message)
        {
            logger.Warn(message);
        }
    }
}
