using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using Vueling.Application.Dto;

namespace Vueling.Common.Layer
{
    public class Log4Net
    {

        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        // static Loggermanager()
        //{
        //    log4net.Config.XmlConfigurator.Configure();
        //}
        //    public static void LogMessage(string message)
        //{
        //    Task.Factory.StartNew(() => log.Info(message));
        //}

        public void AddLog(AlumnoDto alumnoDto)
        {

            var secs = 3;
            Log.Info(alumnoDto);
            Thread.Sleep(TimeSpan.FromSeconds(secs));
        }
    }
}