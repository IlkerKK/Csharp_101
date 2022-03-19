using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ınterfaces
{
    public class DatabaseLogger : Ilogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Database'e Log yazar");
        }

    }
}
