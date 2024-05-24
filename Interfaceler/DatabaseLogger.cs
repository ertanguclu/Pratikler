using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceler
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();

            Console.WriteLine("Database loglandı");
        }
    }
}
