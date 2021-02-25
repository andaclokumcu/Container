using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming___III
{
    class FileLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }

    }
}
