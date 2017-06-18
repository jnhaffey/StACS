using System;
using StACS.Core.Exceptions;

namespace StACS.System.StringExtensions
{
    public static class IsGuidExtension
    {
        /// <summary>
        ///     Evaluates if string is a Guid
        /// </summary>
        /// <param name="source">The string to evaluate</param>
        /// <returns>Boolean indicating if string is a Guid or not</returns>
        public static bool IsGuid(this string source)
        {
            if (!source.HasValue()) throw new SourceEmptyOrNullException(nameof(source));

            Guid value;
            return Guid.TryParse(source, out value);
        }
    }
}