using System;
using System.Text;
using StACS.Core.Exceptions;

namespace StACS.System.StringExtensions
{
    public static class Base64Extensions
    {
        /// <summary>
        ///     Convert a string to a Base64 encoded string
        /// </summary>
        /// <typeparam name="T">Must be one of the Encoding Types</typeparam>
        /// <param name="source">The string to be converted</param>
        /// <returns>Base64 encoded version of the string</returns>
        public static string ToBase64<T>(this string source) where T : Encoding, new()
        {
            if (!source.HasValue()) throw new SourceEmptyOrNullException();
            var encoding = new T();
            return Convert.ToBase64String(encoding.GetBytes(source));
        }

        /// <summary>
        ///     Convert a Base64 encoded string to a string
        /// </summary>
        /// <typeparam name="T">Must be one of the Encoding Types</typeparam>
        /// <param name="source">The base64 encoded string to convert</param>
        /// <returns>The string the base64 encoded string equals</returns>
        public static string FromBase64<T>(this string source) where T : Encoding, new()
        {
            if (!source.HasValue()) throw new SourceEmptyOrNullException(nameof(source));
            var encoding = new T();
            return encoding.GetString(Convert.FromBase64String(source));
        }

        //private static Encoding
    }
}