
namespace DanimarpeNlogElmah.Logger
{
    /// <summary>
    /// Manejador del logger activo del sistema
    /// </summary>
    public interface ILoggerManager
    {
        /// <summary>
        /// Obtiene el logger actual
        /// </summary>
        /// <returns></returns>
        ILogger CurrentLogger { get; set; }

        /// <summary>
        /// Obtiene o establece la factoria de loggers
        /// </summary>
        ILoggerFactory LoggerFactory { get; set; }
    }
}