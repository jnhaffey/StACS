using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System
{
    public static class ContainsCultureInvariantExtension
    {
        /// <summary>
        ///     Evaluates if the string source contains supplied string while ignoring culture
        /// </summary>
        /// <param name="source">The source string to evaluate</param>
        /// <param name="contains">The provided string to compare with</param>
        /// <param name="ignoreCase">Flag to ignore case or not, default is true</param>
        /// <returns>Boolean indicating if supplied string is in the source string</returns>
        public static bool ContainsCultureInvariant(this string source, string contains, bool ignoreCase = true)
        {
            if (source.HasValue() && contains.HasValue())
            {
                return CultureInfo.InvariantCulture.CompareInfo.IndexOf(source, contains, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None) >= 0;
            }
            return false;
        }
    }
}
