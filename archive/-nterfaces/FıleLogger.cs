using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ınterfaces
{
    public class FıleLogger :Ilogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dosyaya Log yazar");
        }
    }
}
