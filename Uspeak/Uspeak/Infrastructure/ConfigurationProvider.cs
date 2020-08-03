using Microsoft.Extensions.Configuration;
using System;

namespace Uspeak.Infrastructure
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        private readonly IConfiguration _configuration;

        public ConfigurationProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public T GetConfigParam<T>(string key, T defaultValue)
        {
            try
            {
                T rawValue = _configuration.GetValue<T>(key);
                if (rawValue == null)
                    return defaultValue;
                else
                    return rawValue;
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
