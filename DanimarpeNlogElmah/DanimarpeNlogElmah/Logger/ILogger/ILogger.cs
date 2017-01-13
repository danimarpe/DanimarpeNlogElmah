using System;

namespace DanimarpeNlogElmah.Logger
{
    public interface ILogger
    {
        /// <summary>
        /// Detailed level. Just to trace the code.
        /// </summary>
        /// <param name="message"></param>
        void Trace(string message);

        /// <summary>
        /// Detailed flow system level. Used to debug the software.
        /// </summary>
        /// <param name="message"></param>
        void Debug(string message);

        /// <summary>
        /// Detailed flow system level. Used to debug the software.
        /// </summary>
        /// <param name="message"></param>
        void Debug(string message, Exception ex);

        /// <summary>
        /// Detailed flow system level. Used to debug the software.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <param name="parametros"></param>
        void Debug(string message, Exception ex, object[] parametros);

        /// <summary>
        ///  Visible in state consoles. Used to log general information.
        /// </summary>
        /// <param name="message"></param>
        void Info(string message);

        /// <summary>
        /// Used to log non "chrash" errors. Visible in state consoles.
        /// </summary>
        /// <param name="message"></param>
        void Warn(string message);

        /// <summary>
        ///  Visible in state consoles. Used to log "crash" exceptions, but not "lethal" to the software.
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);

        /// <summary>
        /// Visible in state consoles. Used to log "crash" exceptions, but not "lethal" to the software.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void Error(string message, Exception exception);

        /// <summary>
        /// Visible in state consoles. Used to log "crash" exceptions, but not "lethal" to the software.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void Error(string message, Exception exception, object[] parametros);

        /// <summary>
        /// Visible in state consoles. Used to log "crash" exceptions, which are "lethal" to the software.
        /// </summary>
        /// <param name="message"></param>
        void Fatal(string message);

        /// <summary>
        /// Visible in state consoles. Used to log "crash" exceptions, which are "lethal" to the software
        /// </summary>
        /// <param name="message"></param>
        void Fatal(string message, Exception exception);

        /// <summary>
        /// Visible in state consoles. Used to log "crash" exceptions, which are "lethal" to the software
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void Fatal(string message, Exception exception, object[] parametros);
    }
}
