using log4net;

namespace Anofoods.Core.Helpers
{
    public class LoggerHelper
    {
        public static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
