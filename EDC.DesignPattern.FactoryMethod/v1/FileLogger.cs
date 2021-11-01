using System;

namespace EDC.DesignPattern.FactoryMethod.v1
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("文件日志记录...");
        }
    }
}
