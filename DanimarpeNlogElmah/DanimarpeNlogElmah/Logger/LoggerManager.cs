using System;

namespace DanimarpeNlogElmah.Logger
{
    /// <summary>
    /// Singleton Pattern. It contains all the loggers.
    /// </summary>
    public class LoggerManager : ILoggerManager
    {
        /// <summary>
        /// Logger which stores the log using Elmah
        /// </summary>
        private ILogger _elmah;
        public ILogger Elmah
        {
            get { return _elmah; }
            set
            {
                _elmah = value;
            }
        }

        /// <summary>
        /// Factory to create the loggers
        /// </summary>
        protected ILoggerFactory _factory;
        public ILoggerFactory LoggerFactory
        {
            get
            {
                return _factory;
            }
            set
            {
                _factory = value;

            }
        }

        /// <summary>
        /// The constructor basically calls the Factory which creates the loggers
        /// </summary>
        private LoggerManager()
        {
            _factory = new LoggerFactory();

            _elmah = _factory.CreateLogger(LoggerKeys.Elmah);
            CurrentLogger = _elmah;
        }

        /// <summary>
        /// Implementation of the singleton pattern
        /// </summary>
        private static LoggerManager _instance = null;
        private static object _lock = new object();
        ILogger _currentlogger = null;
        /// <summary>
        /// Singleton
        /// </summary>
        public static LoggerManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance = new LoggerManager();
                    }
                }

                return _instance;
            }
        }

        /// <summary>
        /// In case of having multiple loggers, this should be pointing to the default one.
        /// </summary>
        public ILogger CurrentLogger
        {
            get
            {
                return _currentlogger;
            }
            set
            {
                if (value == null)
                    throw new ArgumentException();

                _currentlogger = value;
            }
        }
    }

}
