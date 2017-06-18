using System;
using StACS.Core.Exceptions;
using StACS.System.ObjectExtensions;

namespace StACS.System.DatetimeExtensions
{
    public static class GetAgeExtension
    {
        /// <summary>
        /// Gets the age, in years, from the source date to today
        /// </summary>
        /// <param name="source">The source datetime to use</param>
        /// <returns>An integer representing the number of years sonce the date source</returns>
        public static int GetAge(this DateTime source)
        {
            if (source.IsNull()) throw new SourceEmptyOrNullException(nameof(source));

            var today = DateTime.Today;
            if (today.Month < source.Month || (today.Month == source.Month && today.Day < source.Day))
            {
                return today.Year - source.Year - 1;
            }
            return today.Year - source.Year;
        }
    }
}