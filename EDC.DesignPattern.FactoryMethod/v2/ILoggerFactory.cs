namespace EDC.DesignPattern.FactoryMethod.v2
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
        ILogger CreateLogger(string args);
        ILogger CreateLogger(object obj);
    }
}
