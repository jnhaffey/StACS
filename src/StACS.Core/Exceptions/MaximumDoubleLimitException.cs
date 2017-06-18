using System;
using System.Collections.Generic;
using System.Text;

namespace StACS.Core.Exceptions
{
    /// <summary>
    ///     Used when the Maximum Double Limit is used
    /// </summary>
    public class MaximumDoubleLimitException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MaximumDoubleLimitException" /> class
        /// </summary>
        public MaximumDoubleLimitException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="MaximumDoubleLimitException" /> class
        /// </summary>
        /// <param name="message">A friendly error message</param>
        public MaximumDoubleLimitException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="MaximumDoubleLimitException" /> class
        /// </summary>
        /// <param name="message">A friendly error message</param>
        /// <param name="innerException">An exception that was handled by <see cref="MaximumDoubleLimitException" /></param>
        public MaximumDoubleLimitException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
