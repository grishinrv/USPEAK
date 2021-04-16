namespace Uspeak.Infrastructure
{
    public interface IConfigurationProvider
    {
        T GetConfigParam<T>(string key, T defaultValue);
    }
}
