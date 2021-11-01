namespace EDC.DesignPattern.FactoryMethod.v1
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            // 创建文件日志记录器
            ILogger logger = new FileLogger();
            // 创建文件，代码省略
            return logger;
        }
    }
}
