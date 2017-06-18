using System;

namespace StACS.Core.Exceptions
{
    /// <summary>
    ///     Used when the Minimum Double Limit is used
    /// </summary>
    public class MinimumDoubleLimitException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MinimumDoubleLimitException" /> class
        /// </summary>
        public MinimumDoubleLimitException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="MinimumDoubleLimitException" /> class
        /// </summary>
        /// <param name="message">A friendly error message</param>
        public MinimumDoubleLimitException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="MinimumDoubleLimitException" /> class
        /// </summary>
        /// <param name="message">A friendly error message</param>
        /// <param name="innerException">An exception that was handled by <see cref="MinimumDoubleLimitException" /></param>
        public MinimumDoubleLimitException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
