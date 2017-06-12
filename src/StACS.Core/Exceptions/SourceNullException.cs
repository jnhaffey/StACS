using System;

namespace StACS.Core.Exceptions
{
    /// <summary>
    ///     Used when the source is null
    /// </summary>
    public class SourceNullException : ArgumentNullException
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SourceNullException" /> class
        /// </summary>
        public SourceNullException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SourceNullException" /> class
        /// </summary>
        /// <param name="message">A friendly error message</param>
        public SourceNullException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SourceNullException" /> class
        /// </summary>
        /// <param name="message">A friendly error message</param>
        /// <param name="innerException">An exception that was handled by <see cref="SourceNullException" /></param>
        public SourceNullException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}