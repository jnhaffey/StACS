using System;
using StACS.Core.Exceptions;

namespace StACS.System.Extensions.String
{
    public static class ToBytesExtension
    {
        /// <summary>
        ///     Convert a string to a byte array
        /// </summary>
        /// <param name="source">The string to be converted</param>
        /// <returns>A byte array version of the string</returns>
        public static byte[] ToBytes(this string source)
        {
            if (!source.HasValue()) throw new SourceEmptyOrNullException(nameof(source));

            var bytes = new byte[source.Length * sizeof(char)];
            Buffer.BlockCopy(source.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    }
}