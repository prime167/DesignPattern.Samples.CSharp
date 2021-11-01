using System;

namespace EDC.DesignPattern.FactoryMethod
{
    public class AppConfigHelper
    {
        public static string GetLoggerFactoryName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationHelper.GetByName("LoggerFactory");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factoryName;
        }

        public static object GetLoggerFactoryInstance()
        {
            string assemblyName = GetLoggerFactoryName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}
