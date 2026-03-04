using System;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    internal static class RequestHelpers
    {
        /// <summary>
        /// Validates timestamp requirement consistency. Throws if required but missing, or provided but not required.
        /// </summary>
        internal static void ValidateTimestamp(bool isTimestampRequired, DateTime? timestamp)
        {
            if (isTimestampRequired && !timestamp.HasValue)
                throw new ArgumentException("A timestamp is required but was not provided.");
            if (!isTimestampRequired && timestamp.HasValue)
                throw new ArgumentException("A timestamp was provided but is not required.");
        }
    }
}
