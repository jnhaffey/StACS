using StACS.Core.Exceptions;
using StACS.System.ObjectExtensions;

namespace System
{
    /// <summary>
    ///     DateTime Extension Method
    /// </summary>
    public static class IsWeekendExtension
    {
        /// <summary>
        ///     Evaluates if provided datetime is Saturday or Sunday
        /// </summary>
        /// <param name="source">The datetime to evaluate</param>
        /// <returns>Boolean indicating if datetime is Saturday or Sunday</returns>
        public static bool IsWeekend(this DateTime source)
        {
            return source.DayOfWeek == DayOfWeek.Sunday || source.DayOfWeek == DayOfWeek.Saturday;
        }

        /// <summary>
        ///     Evaluates if provided atetime is Saturday or Sunday
        /// </summary>
        /// <param name="source">The datetime to evaluate</param>
        /// <returns>Boolean indicating if datetime is Saturday or Sunday</returns>
        public static bool IsWeekend(this DateTime? source)
        {
            if (source.IsNull()) throw new SourceEmptyOrNullException(nameof(source));
            return source.Value.DayOfWeek == DayOfWeek.Sunday || source.Value.DayOfWeek == DayOfWeek.Saturday;
        }
    }
}