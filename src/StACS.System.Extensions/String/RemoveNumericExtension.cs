using StACS.Core.Exceptions;
using System;
using System.Text.RegularExpressions;

namespace StACS.System.StringExtensions
{
    public static class RemoveNumericExtension
    {
        /// <summary>
        ///     Will remove all number characters from within the source string
        /// </summary>
        /// <param name="source">The string source to execute against</param>
        /// <returns>The modified string value</returns>
        public static string RemoveNumeric(this string source)
        {
            if (!source.HasValue()) throw new SourceEmptyOrNullException(nameof(source));

            return new Regex("[0-9]").Replace(source, string.Empty);
        }
    }
}