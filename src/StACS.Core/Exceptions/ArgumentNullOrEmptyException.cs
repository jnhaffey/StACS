using System;

namespace StACS.Core.Exceptions
{
    /// <summary>
    ///     Used when the argument is null or empty
    /// </summary>
    public class ArgumentNullOrEmptyException : ArgumentNullException
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ArgumentNullOrEmptyException" /> class
        /// </summary>
        public ArgumentNullOrEmptyException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ArgumentNullOrEmptyException" /> class
        /// </summary>
        /// <param name="message">A friendly error message</param>
        public ArgumentNullOrEmptyException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ArgumentNullOrEmptyException" /> class
        /// </summary>
        /// <param name="message">A friendly error message</param>
        /// <param name="innerException">An exception that was handled by <see cref="SourceEmptyException" /></param>
        public ArgumentNullOrEmptyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}