using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanimarpeNlogElmah.Logger
{
    /// <summary>
    /// Stores the logs using Elmah
    /// </summary>
    public class ElmahLogger : BaseLogger
    {
        public ElmahLogger()
           : base(LoggerKeys.Elmah)
        { }
    }

}
