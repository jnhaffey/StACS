using StACS.Core.Exceptions;
using System;
using System.Text.RegularExpressions;

namespace StACS.System.StringExtensions
{
    public static class RemoveAlphaExtension
    {
        /// <summary>
        ///     Will remove all alpha characters from within the source string
        /// </summary>
        /// <param name="source">The string source to execute against</param>
        /// <returns>The modified string value</returns>
        public static string RemoveAlpha(this string source)
        {
            if (!source.HasValue()) throw new SourceEmptyOrNullException(nameof(source));

            return new Regex("[a-zA-Z]").Replace(source, string.Empty);
        }
    }
}