using Microsoft.Extensions.Configuration;

namespace EDC.DesignPattern.FactoryMethod
{
    public static class ConfigurationHelper
    {
        public static string GetByName(string configKeyName)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            IConfigurationSection section = config.GetSection(configKeyName);

            return section.Value;
        }
    }
}
