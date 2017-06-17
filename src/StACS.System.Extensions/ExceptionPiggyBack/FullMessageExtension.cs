using System.Text;

namespace System
{
    public static class FullMessageExtension
    {
        /// <summary>
        ///     Gathers all exception messages and returns as one string
        /// </summary>
        /// <param name="source">The Exception to gather from</param>
        /// <returns>String of all exception messages</returns>
        public static string FullMessage(this Exception source)
        {
            var stringBuilder = new StringBuilder();
            while (source != null)
            {
                stringBuilder.AppendLine($"{source.Message}");
                source = source.InnerException;
            }
            return stringBuilder.ToString();
        }
    }
}