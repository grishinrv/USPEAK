using System.Threading.Tasks;

namespace Uspeak.Services
{
    /// <summary>
    /// Репозитой изменяемых в рантайм настроек.
    /// </summary>
    public interface IConfigRepository
    {
        /// <summary>
        /// Получить значение.
        /// </summary>
        /// <param name="key">ключ</param>
        Task<string> GetValueAsync(string key);
    }
}
