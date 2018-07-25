using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.Threading.Tasks;

namespace Vueling.Common.Layer
{
    public class Log4Net
    {
        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

       /* public void AddLog(PolizaDto)
        {

            var secs = 3;
            Log.Info();
            Thread.Sleep(TimeSpan.FromSeconds(secs));
        }*/
    }
}
