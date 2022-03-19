using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ınterfaces
{
    public class LogManager:Ilogger
    {
        public Ilogger _logger;
        public LogManager(Ilogger logger)
        {
            _logger = logger;
        }
        
        public void WriteLog()
        {
            _logger.WriteLog();
        }

    }
}
