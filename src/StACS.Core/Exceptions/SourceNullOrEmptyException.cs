using System;

namespace StACS.Core.Exceptions
{
    /// <summary>
    ///     Used when the source is null
    /// </summary>
    public class SourceEmptyOrNullException : ArgumentNullException
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SourceEmptyOrNullException" /> class
        /// </summary>
        public SourceEmptyOrNullException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SourceEmptyOrNullException" /> class
        /// </summary>
        /// <param name="message">A friendly error message</param>
        public SourceEmptyOrNullException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SourceEmptyOrNullException" /> class
        /// </summary>
        /// <param name="message">A friendly error message</param>
        /// <param name="innerException">An exception that was handled by <see cref="SourceEmptyOrNullException" /></param>
        public SourceEmptyOrNullException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}