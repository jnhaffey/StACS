using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using StACS.Core.Exceptions;

namespace StACS.System.StringExtensions
{
    public static class RemoveNonAlphaNumericExtension
    {
        /// <summary>
        ///     Will remove all non-alphanumeric characters from within the source string
        /// </summary>
        /// <param name="source">The string source to execute against</param>
        /// <returns>The modified string value</returns>
        public static string RemoveNonAlphaNumeric(this string source)
        {
            if (!source.HasValue()) throw new SourceEmptyOrNullException(nameof(source));

            return new Regex("[^a-zA-Z0-9 -]").Replace(source, string.Empty);
        }
    }
}
