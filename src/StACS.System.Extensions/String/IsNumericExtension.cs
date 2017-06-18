using StACS.Core.Exceptions;
using System;
using System.Globalization;

namespace StACS.System.StringExtensions
{
    public static class IsNumericExtension
    {
        /// <summary>
        ///     Evaluates if the source string is a number
        /// </summary>
        /// <param name="source">The string source to evaluate</param>
        /// <returns>Boolean indicating if the source string is a number or not</returns>
        public static bool IsNumeric(this string source)
        {
            if (!source.HasValue()) throw new SourceEmptyOrNullException(nameof(source));

            if (source.Equals(double.MinValue.ToString(CultureInfo.InvariantCulture), StringComparison.OrdinalIgnoreCase))
            {
                throw new MinimumDoubleLimitException("The minimum limit of a double was supplied and is unable to parse");
            }

            if (source.Equals(Double.MaxValue.ToString(CultureInfo.InvariantCulture), StringComparison.OrdinalIgnoreCase))
            {
                throw new MaximumDoubleLimitException("The maximum limit of a double was supplied and is unable to parse");
            }

            if (float.TryParse(source, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out float floatValue) ||
                double.TryParse(source, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out double doubleValue) ||
                decimal.TryParse(source, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out decimal decimalValue))
            {
                return true;
            }

            return long.TryParse(source, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out long longValue);
        }
    }
}