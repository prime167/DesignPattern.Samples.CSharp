using EDC.DesignPattern.FactoryMethod.v1;

namespace EDC.DesignPattern.FactoryMethod.v3
{
    public abstract class LoggerFactory
    {
        // 在工厂类中直接调用日志记录器的业务方法WriteLog()
        public void WriteLog()
        {
            ILogger logger = this.CreateLogger();
            logger.WriteLog();
        }

        public abstract ILogger CreateLogger();
    }
}
