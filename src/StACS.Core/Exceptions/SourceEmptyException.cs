using System;

namespace StACS.Core.Exceptions
{
    /// <summary>
    ///     Used when the source is empty
    /// </summary>
    public class SourceEmptyException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SourceEmptyException" /> class
        /// </summary>
        public SourceEmptyException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SourceEmptyException" /> class
        /// </summary>
        /// <param name="message">A friendly error message</param>
        public SourceEmptyException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SourceEmptyException" /> class
        /// </summary>
        /// <param name="message">A friendly error message</param>
        /// <param name="innerException">An exception that was handled by <see cref="SourceEmptyException" /></param>
        public SourceEmptyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}