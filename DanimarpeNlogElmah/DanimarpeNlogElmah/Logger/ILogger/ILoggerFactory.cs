
namespace DanimarpeNlogElmah.Logger
{
    /// <summary>
    /// Interfaz de Factoria para devolver un Logger
    /// </summary>
    public interface ILoggerFactory
    {
        /// <summary>
        /// Creates an instance of logger component based on "default" registration key.
        /// </summary>
        /// <returns></returns>
        ILogger CreateLogger();

        /// <summary>
        /// Creates an instance of logger component based on dependency registration key.
        /// </summary>
        /// <param name="loggerName">The dependency registration key.</param>
        /// <returns>An Instance of logger component.</returns>
        ILogger CreateLogger(string loggerName);
    }
}