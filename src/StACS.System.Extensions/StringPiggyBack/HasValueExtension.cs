namespace System
{
    public static class HasValueExtension
    {
        /// <summary>
        ///     Evaluates if string has value
        /// </summary>
        /// <param name="source">The string to evaluate</param>
        /// <returns>Boolean indicating if string has value or not</returns>
        public static bool HasValue(this string source)
        {
            return !string.IsNullOrWhiteSpace(source);
        }
    }
}