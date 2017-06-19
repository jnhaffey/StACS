using StACS.Core.Exceptions;
using System;
using System.Linq;

namespace StACS.System.StringExtensions
{
    public static class RepeatExtension
    {
        /// <summary>
        ///     Will repeat the source string for the provide count times
        /// </summary>
        /// <param name="source">The string source to repeat</param>
        /// <param name="count">The number of times to repeat</param>
        /// <remarks>Count must be greater than 0</remarks>
        /// <returns>The repeated string value</returns>
        public static string Repeat(this string source, int count)
        {
            if (!source.HasValue()) throw new SourceEmptyOrNullException(nameof(source));

            if (count <= 0) throw new ArgumentOutOfRangeException(nameof(count), count, "Count must be greater than 0");

            return Enumerable.Repeat(source, count).Aggregate((x,y) => x + y);
        }
    }
}