using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearPipeline.Console.Contract
{
    public abstract class BaseLog
    {
        public string _RootPath = AppDomain.CurrentDomain.BaseDirectory;
        public string _FileName = ConfigurationManager.AppSettings["DiskLogFileName"]?.ToString();
        public string _TxtLogSeparator = ConfigurationManager.AppSettings["TxtLogSeparator"]?.ToString();

    }
}
