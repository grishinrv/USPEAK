using System;

namespace Uspeak.Services.Exceptions
{
    /// <summary>
    /// Указаны непересекающиеся дипазано временных промежутков, условие "И" никогда не будет выполнено.ы
    /// </summary>
    public class WrongTimePeriodsException : ArgumentException
    {
        private readonly string _message;

        public WrongTimePeriodsException(string message)
        {
            _message = message;
        }

        public sealed override string Message => _message;
    }
}