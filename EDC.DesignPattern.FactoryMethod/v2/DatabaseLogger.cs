using System;

namespace EDC.DesignPattern.FactoryMethod.v2
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("数据库日志记录...");
        }
    }
}
